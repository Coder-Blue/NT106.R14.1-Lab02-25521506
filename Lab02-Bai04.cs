using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai04 : Form
    {
        public class SinhVien
        {
            public string HoTen = string.Empty;
            public int MSSV;
            public string DienThoai = string.Empty;
            public float DiemMon1;
            public float DiemMon2;
            public float DiemMon3;
            public float DiemTB;
        }

        private List<SinhVien> danhSachNhap = new List<SinhVien>();
        private List<SinhVien> danhSachXuat = new List<SinhVien>();
        private int viTriHienTai = 0;

        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            IncludeFields = true
        };

        public Lab02_Bai04()
        {
            InitializeComponent();
            CapNhatHienThiXuat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTenNhap.Text.Trim();
            string strMssv = txtMssvNhap.Text.Trim();
            string dienThoai = txtDienThoaiNhap.Text.Trim();
            string strDiem1 = txtDiemMon1Nhap.Text.Trim();
            string strDiem2 = txtDiemMon2Nhap.Text.Trim();
            string strDiem3 = txtDiemMon3Nhap.Text.Trim();

            if (hoTen.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Họ và tên sinh viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNhap.Focus();
                return;
            }

            if (strMssv.Length != 8 || !int.TryParse(strMssv, out int mssv) || mssv < 10000000)
            {
                MessageBox.Show("Mã số sinh viên phải là một số nguyên có đúng 8 chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMssvNhap.Focus();
                return;
            }

            if (dienThoai.Length != 10 || !dienThoai.StartsWith("0") || !long.TryParse(dienThoai, out _))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoaiNhap.Focus();
                return;
            }

            if (!float.TryParse(strDiem1, out float diem1) || diem1 < 0 || diem1 > 10)
            {
                MessageBox.Show("Điểm môn 1 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon1Nhap.Focus();
                return;
            }

            if (!float.TryParse(strDiem2, out float diem2) || diem2 < 0 || diem2 > 10)
            {
                MessageBox.Show("Điểm môn 2 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon2Nhap.Focus();
                return;
            }

            if (!float.TryParse(strDiem3, out float diem3) || diem3 < 0 || diem3 > 10)
            {
                MessageBox.Show("Điểm môn 3 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon3Nhap.Focus();
                return;
            }

            danhSachNhap.Add(new SinhVien
            {
                HoTen = hoTen,
                MSSV = mssv,
                DienThoai = dienThoai,
                DiemMon1 = diem1,
                DiemMon2 = diem2,
                DiemMon3 = diem3,
                DiemTB = 0
            });

            lblTrangThai.Text = $"Đã thêm: {hoTen} (Tổng danh sách chờ ghi: {danhSachNhap.Count})";

            txtHoTenNhap.Clear();
            txtMssvNhap.Clear();
            txtDienThoaiNhap.Clear();
            txtDiemMon1Nhap.Clear();
            txtDiemMon2Nhap.Clear();
            txtDiemMon3Nhap.Clear();
            txtHoTenNhap.Focus();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào trong danh sách nhập để ghi xuống file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                GhiDanhSach("input4.txt", danhSachNhap);

                List<SinhVien> docTuInput = DocDanhSach("input4.txt");
                docTuInput.ForEach(sv => sv.DiemTB = TinhDiemTrungBinh(sv));
                GhiDanhSach("output4.txt", docTuInput);

                lblTrangThai.Text = $"Đã ghi {danhSachNhap.Count} sinh viên vào input4.txt và tính điểm TB sang output4.txt";
                MessageBox.Show($"Đã ghi {danhSachNhap.Count} sinh viên xuống input4.txt và tự động tính điểm TB lưu vào output4.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("output4.txt"))
            {
                if (File.Exists("input4.txt"))
                {
                    try
                    {
                        List<SinhVien> docInput = DocDanhSach("input4.txt");
                        docInput.ForEach(sv => sv.DiemTB = TinhDiemTrungBinh(sv));
                        GhiDanhSach("output4.txt", docInput);
                    }
                    catch { }
                }

                if (!File.Exists("output4.txt"))
                {
                    MessageBox.Show("Chưa tìm thấy file output4.txt! Vui lòng nhập và ghi file trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                danhSachXuat = DocDanhSach("output4.txt");
                viTriHienTai = 0;
                CapNhatHienThiXuat();
                lblTrangThai.Text = $"Đã đọc {danhSachXuat.Count} sinh viên từ output4.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file output4.txt: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                CapNhatHienThiXuat();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTriHienTai < danhSachXuat.Count - 1)
            {
                viTriHienTai++;
                CapNhatHienThiXuat();
            }
        }

        private void CapNhatHienThiXuat()
        {
            if (danhSachXuat.Count == 0)
            {
                TextBox[] oXuat = { txtHoTenXuat, txtMssvXuat, txtDienThoaiXuat, txtDiemMon1Xuat, txtDiemMon2Xuat, txtDiemMon3Xuat, txtDiemTbXuat };
                foreach (TextBox o in oXuat)
                {
                    o.Clear();
                }

                lblSoTrang.Text = "0 / 0";
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            viTriHienTai = Math.Clamp(viTriHienTai, 0, danhSachXuat.Count - 1);

            SinhVien sv = danhSachXuat[viTriHienTai];
            txtHoTenXuat.Text = sv.HoTen;
            txtMssvXuat.Text = sv.MSSV.ToString();
            txtDienThoaiXuat.Text = sv.DienThoai;
            txtDiemMon1Xuat.Text = sv.DiemMon1.ToString();
            txtDiemMon2Xuat.Text = sv.DiemMon2.ToString();
            txtDiemMon3Xuat.Text = sv.DiemMon3.ToString();
            txtDiemTbXuat.Text = sv.DiemTB.ToString("F2");

            lblSoTrang.Text = $"{viTriHienTai + 1} / {danhSachXuat.Count}";
            btnBack.Enabled = viTriHienTai > 0;
            btnNext.Enabled = viTriHienTai < danhSachXuat.Count - 1;
        }

        private static float TinhDiemTrungBinh(SinhVien sv) =>
            (float)Math.Round((sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3f, 2);

        private static List<SinhVien> DocDanhSach(string tenFile)
        {
            using (FileStream fs = new FileStream(tenFile, FileMode.Open, FileAccess.Read))
            {
                return JsonSerializer.Deserialize<List<SinhVien>>(fs, jsonOptions) ?? new List<SinhVien>();
            }
        }

        private static void GhiDanhSach(string tenFile, List<SinhVien> danhSach)
        {
            using (FileStream fs = new FileStream(tenFile, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fs, danhSach, jsonOptions);
            }
        }
    }
}
