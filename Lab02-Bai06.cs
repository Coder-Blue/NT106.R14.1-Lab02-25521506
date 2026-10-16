using Microsoft.Data.Sqlite;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai06 : Form
    {
        public class MonAn
        {
            public int IDMA;
            public string TenMonAn = string.Empty;
            public string HinhAnh = string.Empty;
            public int IDNCC;
            public string TenNguoiDongGop = string.Empty;
        }

        public class NguoiDung
        {
            public int IDNCC;
            public string HoVaTen = string.Empty;
            public string QuyenHan = string.Empty;
        }

        private const string DuongDanDb = "homnayangi.db";

        private List<NguoiDung> danhSachNguoiDung = new List<NguoiDung>();

        public Lab02_Bai06()
        {
            InitializeComponent();
            TaoBang();
            TaiNguoiDung();
            TaiDanhSachMonAn();
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMonAn.Text.Trim();

            if (tenMon.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonAn.Focus();
                return;
            }

            if (cmbNguoiDung.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hinhAnh = txtHinhAnh.Text.Trim();
            if (hinhAnh.Length == 0)
            {
                hinhAnh = Path.Combine("hinh-anh", "default.png");
            }

            int idNcc = danhSachNguoiDung[cmbNguoiDung.SelectedIndex].IDNCC;

            try
            {
                using SqliteConnection ketNoi = MoKetNoi();
                ThemMonAn(ketNoi, tenMon, hinhAnh, idNcc);
                TaiDanhSachMonAn();
                lblTrangThai.Text = $"Đã thêm món ăn: {tenMon}";

                txtTenMonAn.Clear();
                txtHinhAnh.Clear();
                txtTenMonAn.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMonAn_Click(object sender, EventArgs e)
        {
            if (lvMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MonAn? mon = lvMonAn.SelectedItems[0].Tag as MonAn;
            if (mon == null)
            {
                return;
            }

            try
            {
                using SqliteConnection ketNoi = MoKetNoi();
                XoaMonAn(ketNoi, mon.IDMA);
                TaiDanhSachMonAn();
                lblTrangThai.Text = $"Đã xoá món ăn: {mon.TenMonAn}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoá món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh món ăn";
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtHinhAnh.Text = ofd.FileName;
            }
        }

        private void btnAnGi_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn? mon = ChonMonAnNgauNhien();
                if (mon == null)
                {
                    MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                lblKetQua.Text = $"Hôm nay ăn:\r\n\r\n{mon.TenMonAn}\r\n\r\nĐóng góp bởi:\r\n{mon.TenNguoiDongGop}";
                HienThiHinh(mon.HinhAnh);
                lblTrangThai.Text = $"Đã chọn ngẫu nhiên: {mon.TenMonAn} (bởi {mon.TenNguoiDongGop})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiNguoiDung()
        {
            danhSachNguoiDung = LayNguoiDung();

            cmbNguoiDung.Items.Clear();
            foreach (NguoiDung nguoi in danhSachNguoiDung)
            {
                cmbNguoiDung.Items.Add(nguoi.HoVaTen);
            }

            if (cmbNguoiDung.Items.Count > 0)
            {
                cmbNguoiDung.SelectedIndex = 0;
            }
        }

        private void TaiDanhSachMonAn()
        {
            lvMonAn.Items.Clear();
            foreach (MonAn mon in LayMonAn())
            {
                ListViewItem dong = new ListViewItem(mon.IDMA.ToString());
                dong.SubItems.Add(mon.TenMonAn);
                dong.SubItems.Add(mon.TenNguoiDongGop);
                dong.Tag = mon;
                lvMonAn.Items.Add(dong);
            }
        }

        private void HienThiHinh(string duongDan)
        {
            Image? hinhCu = picMonAn.Image;
            picMonAn.Image = File.Exists(duongDan) ? TaiHinh(duongDan) : null;
            hinhCu?.Dispose();
        }

        private static Image TaiHinh(string duongDan)
        {
            using FileStream luong = new FileStream(duongDan, FileMode.Open, FileAccess.Read);
            using Image tam = Image.FromStream(luong);
            return new Bitmap(tam);
        }

        private static SqliteConnection MoKetNoi()
        {
            SqliteConnection ketNoi = new SqliteConnection($"Data Source={DuongDanDb}");
            ketNoi.Open();
            return ketNoi;
        }

        private static void TaoBang()
        {
            using SqliteConnection ketNoi = MoKetNoi();

            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText =
                    "CREATE TABLE IF NOT EXISTS NguoiDung (" +
                    "IDNCC INTEGER PRIMARY KEY, " +
                    "HoVaTen TEXT NOT NULL, " +
                    "QuyenHan TEXT NOT NULL);" +
                    "CREATE TABLE IF NOT EXISTS MonAn (" +
                    "IDMA INTEGER PRIMARY KEY, " +
                    "TenMonAn TEXT NOT NULL, " +
                    "HinhAnh TEXT NOT NULL, " +
                    "IDNCC INTEGER NOT NULL, " +
                    "FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC));";
                lenh.ExecuteNonQuery();
            }

            long soMonAn;
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText = "SELECT COUNT(*) FROM MonAn";
                soMonAn = (long)lenh.ExecuteScalar()!;
            }

            if (soMonAn > 0)
            {
                return;
            }

            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText =
                    "INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES " +
                    "(1, 'Nguyễn Văn A', 'Admin'), " +
                    "(2, 'Trần Thị B', 'Thành viên'), " +
                    "(3, 'Lê Văn C', 'Thành viên')";
                lenh.ExecuteNonQuery();
            }

            string[,] monAns =
            {
                { "Bún riêu", "bun-rieu.png", "1" },
                { "Bún thịt nướng", "bun-thit-nuong.png", "2" },
                { "Cơm tấm sườn trứng", "com-tam.png", "3" },
                { "Phở", "pho.png", "1" },
                { "Gỏi cuốn", "goi-cuon.png", "2" }
            };

            for (int i = 0; i < monAns.GetLength(0); i++)
            {
                ThemMonAn(ketNoi, monAns[i, 0], Path.Combine("hinh-anh", monAns[i, 1]), int.Parse(monAns[i, 2]));
            }
        }

        private static List<NguoiDung> LayNguoiDung()
        {
            List<NguoiDung> ketQua = new List<NguoiDung>();

            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "SELECT IDNCC, HoVaTen, QuyenHan FROM NguoiDung ORDER BY IDNCC";

            using SqliteDataReader doc = lenh.ExecuteReader();
            while (doc.Read())
            {
                ketQua.Add(new NguoiDung
                {
                    IDNCC = doc.GetInt32(0),
                    HoVaTen = doc.GetString(1),
                    QuyenHan = doc.GetString(2)
                });
            }

            return ketQua;
        }

        private static List<MonAn> LayMonAn()
        {
            List<MonAn> ketQua = new List<MonAn>();

            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = CauLenhChonMonAn + " ORDER BY ma.IDMA";

            using SqliteDataReader doc = lenh.ExecuteReader();
            while (doc.Read())
            {
                ketQua.Add(DocMonAn(doc));
            }

            return ketQua;
        }

        private static MonAn? ChonMonAnNgauNhien()
        {
            using SqliteConnection ketNoi = MoKetNoi();
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = CauLenhChonMonAn + " ORDER BY RANDOM() LIMIT 1";

            using SqliteDataReader doc = lenh.ExecuteReader();
            return doc.Read() ? DocMonAn(doc) : null;
        }

        private const string CauLenhChonMonAn =
            "SELECT ma.IDMA, ma.TenMonAn, ma.HinhAnh, ma.IDNCC, nd.HoVaTen " +
            "FROM MonAn ma JOIN NguoiDung nd ON ma.IDNCC = nd.IDNCC";

        private static MonAn DocMonAn(SqliteDataReader doc) => new MonAn
        {
            IDMA = doc.GetInt32(0),
            TenMonAn = doc.GetString(1),
            HinhAnh = doc.GetString(2),
            IDNCC = doc.GetInt32(3),
            TenNguoiDongGop = doc.GetString(4)
        };

        private static void ThemMonAn(SqliteConnection ketNoi, string tenMon, string hinhAnh, int idNcc)
        {
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ($ten, $hinh, $idncc)";
            lenh.Parameters.AddWithValue("$ten", tenMon);
            lenh.Parameters.AddWithValue("$hinh", hinhAnh);
            lenh.Parameters.AddWithValue("$idncc", idNcc);
            lenh.ExecuteNonQuery();
        }

        private static void XoaMonAn(SqliteConnection ketNoi, int idMa)
        {
            using SqliteCommand lenh = ketNoi.CreateCommand();
            lenh.CommandText = "DELETE FROM MonAn WHERE IDMA = $id";
            lenh.Parameters.AddWithValue("$id", idMa);
            lenh.ExecuteNonQuery();
        }
    }
}
