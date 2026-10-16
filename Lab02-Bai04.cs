using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai04 : Form
    {
        [Serializable]
        public class SinhVien
        {
            public string HoTen { get; set; } = string.Empty;
            public int MSSV { get; set; }
            public string DienThoai { get; set; } = string.Empty;
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }
            public float DiemTB { get; set; }
        }

        private List<SinhVien> danhSachNhap = new List<SinhVien>();
        private List<SinhVien> danhSachXuat = new List<SinhVien>();
        private int viTriHienTai = 0;

        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
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

            // Validate HoTen
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên sinh viên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTenNhap.Focus();
                return;
            }

            // Validate MSSV: int, 8 chu so
            if (strMssv.Length != 8 || !int.TryParse(strMssv, out int mssv) || mssv < 10000000)
            {
                MessageBox.Show("Mã số sinh viên phải là một số nguyên có đúng 8 chữ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMssvNhap.Focus();
                return;
            }

            // Validate DienThoai: 10 chu so va bat dau bang 0
            if (dienThoai.Length != 10 || !dienThoai.StartsWith("0") || !long.TryParse(dienThoai, out _))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoaiNhap.Focus();
                return;
            }

            // Validate DiemMon1
            if (!float.TryParse(strDiem1, out float diem1) || diem1 < 0 || diem1 > 10)
            {
                MessageBox.Show("Điểm môn 1 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon1Nhap.Focus();
                return;
            }

            // Validate DiemMon2
            if (!float.TryParse(strDiem2, out float diem2) || diem2 < 0 || diem2 > 10)
            {
                MessageBox.Show("Điểm môn 2 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon2Nhap.Focus();
                return;
            }

            // Validate DiemMon3
            if (!float.TryParse(strDiem3, out float diem3) || diem3 < 0 || diem3 > 10)
            {
                MessageBox.Show("Điểm môn 3 phải nằm trong khoảng từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemMon3Nhap.Focus();
                return;
            }

            SinhVien sv = new SinhVien
            {
                HoTen = hoTen,
                MSSV = mssv,
                DienThoai = dienThoai,
                DiemMon1 = diem1,
                DiemMon2 = diem2,
                DiemMon3 = diem3,
                DiemTB = 0 // Khong nhap diem trung binh theo yeu cau
            };

            danhSachNhap.Add(sv);
            lblTrangThai.Text = $"Đã thêm: {hoTen} (Tổng danh sách chờ ghi: {danhSachNhap.Count})";

            // Xoa o nhap de nhap sinh vien tiep theo
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
                // Ghi mảng sinh viên xuống input4.txt bằng JsonSerializer
                using (FileStream fs = new FileStream("input4.txt", FileMode.Create, FileAccess.Write))
                {
                    JsonSerializer.Serialize(fs, danhSachNhap, jsonOptions);
                }

                // Đọc lại từ input4.txt, tính điểm trung bình cho từng sinh viên, ghi xuống output4.txt
                List<SinhVien>? docTuInput;
                using (FileStream fs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read))
                {
                    docTuInput = JsonSerializer.Deserialize<List<SinhVien>>(fs, jsonOptions);
                }

                if (docTuInput != null)
                {
                    foreach (var sv in docTuInput)
                    {
                        sv.DiemTB = (float)Math.Round((sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3f, 2);
                    }

                    using (FileStream fs = new FileStream("output4.txt", FileMode.Create, FileAccess.Write))
                    {
                        JsonSerializer.Serialize(fs, docTuInput, jsonOptions);
                    }
                }

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
                // Neu chua co output4.txt nhung co input4.txt thi thu tu dong tinh tu input4.txt
                if (File.Exists("input4.txt"))
                {
                    try
                    {
                        List<SinhVien>? docInput;
                        using (FileStream fs = new FileStream("input4.txt", FileMode.Open, FileAccess.Read))
                        {
                            docInput = JsonSerializer.Deserialize<List<SinhVien>>(fs, jsonOptions);
                        }

                        if (docInput != null)
                        {
                            foreach (var sv in docInput)
                            {
                                sv.DiemTB = (float)Math.Round((sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3f, 2);
                            }

                            using (FileStream fs = new FileStream("output4.txt", FileMode.Create, FileAccess.Write))
                            {
                                JsonSerializer.Serialize(fs, docInput, jsonOptions);
                            }
                        }
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
                using (FileStream fs = new FileStream("output4.txt", FileMode.Open, FileAccess.Read))
                {
                    danhSachXuat = JsonSerializer.Deserialize<List<SinhVien>>(fs, jsonOptions) ?? new List<SinhVien>();
                }

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
                txtHoTenXuat.Clear();
                txtMssvXuat.Clear();
                txtDienThoaiXuat.Clear();
                txtDiemMon1Xuat.Clear();
                txtDiemMon2Xuat.Clear();
                txtDiemMon3Xuat.Clear();
                txtDiemTbXuat.Clear();
                lblSoTrang.Text = "0 / 0";
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            if (viTriHienTai < 0) viTriHienTai = 0;
            if (viTriHienTai >= danhSachXuat.Count) viTriHienTai = danhSachXuat.Count - 1;

            SinhVien sv = danhSachXuat[viTriHienTai];
            txtHoTenXuat.Text = sv.HoTen;
            txtMssvXuat.Text = sv.MSSV.ToString();
            txtDienThoaiXuat.Text = sv.DienThoai;
            txtDiemMon1Xuat.Text = sv.DiemMon1.ToString();
            txtDiemMon2Xuat.Text = sv.DiemMon2.ToString();
            txtDiemMon3Xuat.Text = sv.DiemMon3.ToString();
            txtDiemTbXuat.Text = sv.DiemTB.ToString("F2");

            lblSoTrang.Text = $"{viTriHienTai + 1} / {danhSachXuat.Count}";
            btnBack.Enabled = (viTriHienTai > 0);
            btnNext.Enabled = (viTriHienTai < danhSachXuat.Count - 1);
        }
    }
}
