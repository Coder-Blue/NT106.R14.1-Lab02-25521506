using System.Text;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai07 : Form
    {
        private const long KichThuocToiDaXemTruoc = 1024 * 1024;

        private bool dangDangTaiODia = false;

        public Lab02_Bai07()
        {
            InitializeComponent();
            TaiODia();
            TaiThuMuc(ThuMucBatDau());
        }

        private void cmbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangDangTaiODia || cmbODia.SelectedItem == null)
            {
                return;
            }

            TaiThuMuc(cmbODia.SelectedItem.ToString() ?? "");
        }

        private void btnDi_Click(object sender, EventArgs e)
        {
            string duongDan = txtDuongDan.Text.Trim();

            if (!Directory.Exists(duongDan))
            {
                MessageBox.Show("Đường dẫn không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiThuMuc(duongDan);
        }

        private void btnLen_Click(object sender, EventArgs e)
        {
            DirectoryInfo? thuMucCha = Directory.GetParent(txtDuongDan.Text.Trim());

            if (thuMucCha == null)
            {
                MessageBox.Show("Đã ở thư mục gốc, không thể lên trên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TaiThuMuc(thuMucCha.FullName);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiThuMuc(txtDuongDan.Text.Trim());
        }

        private void lvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                return;
            }

            string duongDan = lvDanhSach.SelectedItems[0].Tag?.ToString() ?? "";

            if (Directory.Exists(duongDan))
            {
                TaiThuMuc(duongDan);
            }
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count == 0)
            {
                return;
            }

            string duongDan = lvDanhSach.SelectedItems[0].Tag?.ToString() ?? "";

            if (Directory.Exists(duongDan))
            {
                HienThiThuMuc(duongDan);
            }
            else if (File.Exists(duongDan))
            {
                HienThiFile(duongDan);
            }
        }

        private void TaiODia()
        {
            dangDangTaiODia = true;
            cmbODia.Items.Clear();

            foreach (DriveInfo oDia in DriveInfo.GetDrives())
            {
                cmbODia.Items.Add(oDia.Name);
            }

            dangDangTaiODia = false;
        }

        private void ChonODiaTheoDuongDan(string duongDan)
        {
            string tenODia = Path.GetPathRoot(Path.GetFullPath(duongDan)) ?? "";

            dangDangTaiODia = true;
            for (int i = 0; i < cmbODia.Items.Count; i++)
            {
                if (string.Equals(cmbODia.Items[i]?.ToString(), tenODia, StringComparison.OrdinalIgnoreCase))
                {
                    cmbODia.SelectedIndex = i;
                    break;
                }
            }
            dangDangTaiODia = false;
        }

        private void TaiThuMuc(string duongDan)
        {
            try
            {
                string dayDu = Path.GetFullPath(duongDan);
                lvDanhSach.Items.Clear();

                foreach (string thuMuc in Directory.GetDirectories(dayDu).OrderBy(d => d))
                {
                    lvDanhSach.Items.Add(TaoDong(thuMuc, "Thư mục", "", ""));
                }

                foreach (string tep in Directory.GetFiles(dayDu).OrderBy(f => f))
                {
                    FileInfo thongTin = new FileInfo(tep);
                    lvDanhSach.Items.Add(TaoDong(tep, "Tệp", DinhDangKichThuoc(thongTin.Length), thongTin.LastWriteTime.ToString("dd/MM/yyyy HH:mm")));
                }

                txtDuongDan.Text = dayDu;
                ChonODiaTheoDuongDan(dayDu);
                lblTrangThai.Text = $"Đang xem: {dayDu} ({lvDanhSach.Items.Count} mục)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc thư mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiThuMuc(string duongDan)
        {
            int soThuMucCon = 0;
            int soFile = 0;

            try
            {
                soThuMucCon = Directory.GetDirectories(duongDan).Length;
                soFile = Directory.GetFiles(duongDan).Length;
            }
            catch (Exception ex)
            {
                rtbNoiDung.Text = $"[Không đọc được thư mục: {ex.Message}]";
                return;
            }

            lblThongTinFile.Text = $"Thư mục: {new DirectoryInfo(duongDan).Name}\r\n{duongDan}";
            rtbNoiDung.Text = $"[Thư mục] {soThuMucCon} thư mục con, {soFile} file\r\nNhấn đúp chuột để mở thư mục này.";
        }

        private void HienThiFile(string duongDan)
        {
            FileInfo thongTin = new FileInfo(duongDan);
            lblThongTinFile.Text = $"{thongTin.Name}\r\n{DinhDangKichThuoc(thongTin.Length)}\r\n{duongDan}";

            if (thongTin.Length > KichThuocToiDaXemTruoc)
            {
                rtbNoiDung.Text = "[File quá lớn để xem trước]";
                return;
            }

            try
            {
                byte[] duLieu = File.ReadAllBytes(duongDan);

                if (LaFileNhiPhan(duLieu))
                {
                    rtbNoiDung.Text = "[File nhị phân, không hiển thị nội dung]";
                    return;
                }

                rtbNoiDung.Text = Encoding.UTF8.GetString(duLieu);
            }
            catch (Exception ex)
            {
                rtbNoiDung.Text = $"[Không đọc được file: {ex.Message}]";
            }
        }

        private static string ThuMucBatDau()
        {
            string thuMuc = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Directory.Exists(thuMuc) ? thuMuc : Environment.CurrentDirectory;
        }

        private static ListViewItem TaoDong(string duongDan, string loai, string kichThuoc, string suaDoi)
        {
            ListViewItem dong = new ListViewItem(Path.GetFileName(duongDan));
            dong.SubItems.Add(loai);
            dong.SubItems.Add(kichThuoc);
            dong.SubItems.Add(suaDoi);
            dong.Tag = duongDan;
            return dong;
        }

        private static string DinhDangKichThuoc(long soByte)
        {
            if (soByte < 1024)
            {
                return $"{soByte} B";
            }

            if (soByte < 1024 * 1024)
            {
                return $"{soByte / 1024.0:0.0} KB";
            }

            if (soByte < 1024L * 1024 * 1024)
            {
                return $"{soByte / (1024.0 * 1024):0.0} MB";
            }

            return $"{soByte / (1024.0 * 1024 * 1024):0.0} GB";
        }

        private static bool LaFileNhiPhan(byte[] duLieu) => duLieu.Take(8000).Any(b => b == 0);
    }
}
