namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai05 : Form
    {
        public class PhongVe
        {
            public string TenPhim = string.Empty;
            public int GiaVeChuan;
            public int PhongChieu;
        }

        public class ThongKe
        {
            public string TenPhim = string.Empty;
            public int SoVeBan;
            public int SoVeTon;
            public double TiLe;
            public int DoanhThu;
            public int XepHang;
        }

        private List<PhongVe> danhSachPhongVe = new List<PhongVe>();
        private Dictionary<string, HashSet<string>> gheDaBan = new Dictionary<string, HashSet<string>>();

        private static readonly string[] TatCaGhe =
        {
            "A1", "A2", "A3", "A4", "A5",
            "B1", "B2", "B3", "B4", "B5",
            "C1", "C2", "C3", "C4", "C5"
        };

        public Lab02_Bai05()
        {
            InitializeComponent();
            DocInput5();
        }

        private void btnThemPhongVe_Click(object sender, EventArgs e)
        {
            string tenPhim = txtTenPhim.Text.Trim();
            string strGiaVe = txtGiaVe.Text.Trim();
            string strPhong = txtPhong.Text.Trim();

            if (tenPhim.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhim.Focus();
                return;
            }

            if (!int.TryParse(strGiaVe, out int giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé chuẩn phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return;
            }

            if (!int.TryParse(strPhong, out int phong) || phong <= 0)
            {
                MessageBox.Show("Phòng chiếu phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhong.Focus();
                return;
            }

            danhSachPhongVe.Add(new PhongVe { TenPhim = tenPhim, GiaVeChuan = giaVe, PhongChieu = phong });
            LamMoiDanhSachPhongVe();
            lblTrangThai.Text = $"Đã thêm phòng vé: {tenPhim} - phòng {phong}";

            txtTenPhim.Clear();
            txtGiaVe.Clear();
            txtPhong.Clear();
            txtTenPhim.Focus();
        }

        private void btnXoaPhongVe_Click(object sender, EventArgs e)
        {
            if (lstPhongVe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một phòng vé trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSachPhongVe.RemoveAt(lstPhongVe.SelectedIndex);
            LamMoiDanhSachPhongVe();
            lblTrangThai.Text = "Đã xoá phòng vé đang chọn";
        }

        private void btnGhiInput_Click(object sender, EventArgs e)
        {
            try
            {
                GhiInput5(danhSachPhongVe);
                lblTrangThai.Text = $"Đã ghi {danhSachPhongVe.Count} phòng vé xuống input5.txt";
                MessageBox.Show("Đã ghi danh sách phòng vé xuống input5.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocInput_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input5.txt"))
            {
                MessageBox.Show("Chưa tìm thấy file input5.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DocInput5();
        }

        private void cmbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPhong.Items.Clear();

            string phim = cmbPhim.Text;
            foreach (int phong in danhSachPhongVe.Where(pv => pv.TenPhim == phim).Select(pv => pv.PhongChieu).Distinct())
            {
                cmbPhong.Items.Add(phong);
            }

            if (cmbPhong.Items.Count > 0)
            {
                cmbPhong.SelectedIndex = 0;
            }
            else
            {
                CapNhatGheTrong();
            }
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGheTrong();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string tenKhach = txtKhachHang.Text.Trim();

            if (tenKhach.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhachHang.Focus();
                return;
            }

            if (cmbPhim.SelectedIndex < 0 || cmbPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> gheChon = clbGhe.CheckedItems.Cast<string>().ToList();
            if (gheChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phim = cmbPhim.Text;
            int phong = (int)cmbPhong.SelectedItem!;
            int giaVeChuan = danhSachPhongVe.First(pv => pv.TenPhim == phim && pv.PhongChieu == phong).GiaVeChuan;
            int tongTien = TinhTien(giaVeChuan, gheChon);

            string khoa = $"{phim}|{phong}";
            if (!gheDaBan.ContainsKey(khoa))
            {
                gheDaBan[khoa] = new HashSet<string>();
            }

            foreach (string ghe in gheChon)
            {
                gheDaBan[khoa].Add(ghe);
            }

            rtbKetQua.Text = $"Khách hàng: {tenKhach}\r\n" +
                             $"Phim: {phim}\r\n" +
                             $"Phòng chiếu: {phong}\r\n" +
                             $"Vé đã chọn: {string.Join(", ", gheChon)}\r\n" +
                             $"Cần thanh toán: {tongTien:N0} VNĐ";

            lblTrangThai.Text = $"Đã bán {gheChon.Count} vé cho {tenKhach}";
            txtKhachHang.Clear();
            CapNhatGheTrong();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (danhSachPhongVe.Count == 0)
            {
                MessageBox.Show("Chưa có phòng vé nào! Vui lòng nhập hoặc đọc input5.txt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<ThongKe> thongKe = TinhThongKe();

                progressBar.Minimum = 0;
                progressBar.Maximum = thongKe.Count;
                progressBar.Value = 0;

                List<string> dong = new List<string>();
                dong.Add("Tên phim | Số vé bán | Số vé tồn | Tỉ lệ bán | Doanh thu | Xếp hạng");

                foreach (ThongKe tk in thongKe)
                {
                    dong.Add($"{tk.TenPhim} | {tk.SoVeBan} | {tk.SoVeTon} | {tk.TiLe:P0} | {tk.DoanhThu:N0} | {tk.XepHang}");
                    progressBar.Value++;
                    progressBar.Refresh();
                    Application.DoEvents();
                    Thread.Sleep(200);
                }

                File.WriteAllLines("output5.txt", dong);
                rtbThongKe.Text = File.ReadAllText("output5.txt");
                lblTrangThai.Text = $"Đã xuất thống kê {thongKe.Count} phim xuống output5.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DocInput5()
        {
            danhSachPhongVe = DocInput5TuFile();
            LamMoiDanhSachPhongVe();
            lblTrangThai.Text = $"Đã đọc {danhSachPhongVe.Count} phòng vé từ input5.txt";
        }

        private void LamMoiDanhSachPhongVe()
        {
            lstPhongVe.Items.Clear();
            foreach (PhongVe pv in danhSachPhongVe)
            {
                lstPhongVe.Items.Add($"{pv.TenPhim} - phòng {pv.PhongChieu} - {pv.GiaVeChuan:N0}đ");
            }

            string phimDangChon = cmbPhim.Text;
            cmbPhim.Items.Clear();
            foreach (string tenPhim in danhSachPhongVe.Select(pv => pv.TenPhim).Distinct())
            {
                cmbPhim.Items.Add(tenPhim);
            }

            int viTri = cmbPhim.Items.IndexOf(phimDangChon);
            if (viTri >= 0)
            {
                cmbPhim.SelectedIndex = viTri;
            }
            else
            {
                cmbPhong.Items.Clear();
                clbGhe.Items.Clear();
            }
        }

        private void CapNhatGheTrong()
        {
            clbGhe.Items.Clear();

            if (cmbPhim.SelectedIndex < 0 || cmbPhong.SelectedIndex < 0)
            {
                return;
            }

            string khoa = $"{cmbPhim.Text}|{cmbPhong.Text}";
            if (!gheDaBan.TryGetValue(khoa, out HashSet<string>? daBan) || daBan == null)
            {
                daBan = new HashSet<string>();
            }

            foreach (string ghe in TatCaGhe)
            {
                if (!daBan.Contains(ghe))
                {
                    clbGhe.Items.Add(ghe);
                }
            }
        }

        private List<ThongKe> TinhThongKe()
        {
            List<ThongKe> ketQua = danhSachPhongVe
                .Select(pv => pv.TenPhim)
                .Distinct()
                .Select(TinhThongKePhim)
                .ToList();

            List<string> theoDoanhThu = ketQua
                .OrderByDescending(tk => tk.DoanhThu)
                .Select(tk => tk.TenPhim)
                .ToList();

            foreach (ThongKe tk in ketQua)
            {
                tk.XepHang = theoDoanhThu.IndexOf(tk.TenPhim) + 1;
            }

            return ketQua;
        }

        private ThongKe TinhThongKePhim(string tenPhim)
        {
            List<int> cacPhong = danhSachPhongVe
                .Where(pv => pv.TenPhim == tenPhim)
                .Select(pv => pv.PhongChieu)
                .Distinct()
                .ToList();

            int giaVeChuan = danhSachPhongVe.First(pv => pv.TenPhim == tenPhim).GiaVeChuan;
            int sucChua = cacPhong.Count * TatCaGhe.Length;
            int soVeBan = 0;
            int doanhThu = 0;

            foreach (int phong in cacPhong)
            {
                string khoa = $"{tenPhim}|{phong}";
                if (!gheDaBan.TryGetValue(khoa, out HashSet<string>? daBan) || daBan == null)
                {
                    continue;
                }

                soVeBan += daBan.Count;
                doanhThu += daBan.Sum(ghe => (int)Math.Round(giaVeChuan * HeSoGhe(ghe), MidpointRounding.AwayFromZero));
            }

            return new ThongKe
            {
                TenPhim = tenPhim,
                SoVeBan = soVeBan,
                SoVeTon = sucChua - soVeBan,
                TiLe = sucChua == 0 ? 0 : (double)soVeBan / sucChua,
                DoanhThu = doanhThu,
                XepHang = 0
            };
        }

        private static double HeSoGhe(string ghe)
        {
            if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
            {
                return 0.25;
            }

            if (ghe == "B2" || ghe == "B3" || ghe == "B4")
            {
                return 2.0;
            }

            return 1.0;
        }

        private static int TinhTien(int giaVeChuan, IEnumerable<string> gheChon) =>
            (int)Math.Round(gheChon.Sum(ghe => giaVeChuan * HeSoGhe(ghe)), MidpointRounding.AwayFromZero);

        private static List<PhongVe> DocInput5TuFile()
        {
            List<PhongVe> ketQua = new List<PhongVe>();
            if (!File.Exists("input5.txt"))
            {
                return ketQua;
            }

            string[] dong = File.ReadAllLines("input5.txt");
            for (int i = 0; i + 2 < dong.Length; i += 3)
            {
                string tenPhim = dong[i].Trim();
                string strGiaVe = dong[i + 1].Trim();
                string strPhong = dong[i + 2].Trim();

                if (tenPhim.Length == 0 || !int.TryParse(strGiaVe, out int giaVe) || !int.TryParse(strPhong, out int phong))
                {
                    continue;
                }

                ketQua.Add(new PhongVe { TenPhim = tenPhim, GiaVeChuan = giaVe, PhongChieu = phong });
            }

            return ketQua;
        }

        private static void GhiInput5(List<PhongVe> danhSach)
        {
            List<string> dong = new List<string>();
            foreach (PhongVe pv in danhSach)
            {
                dong.Add(pv.TenPhim);
                dong.Add(pv.GiaVeChuan.ToString());
                dong.Add(pv.PhongChieu.ToString());
            }

            File.WriteAllLines("input5.txt", dong);
        }
    }
}
