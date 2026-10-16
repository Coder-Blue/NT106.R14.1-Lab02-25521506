namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file văn bản";
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    string tenFile = ofd.SafeFileName;
                    string duongDan = ofd.FileName;
                    long kichThuoc = new FileInfo(duongDan).Length;
                    string noiDung = File.ReadAllText(duongDan);

                    txtTenFile.Text = tenFile;
                    txtKichThuoc.Text = $"{kichThuoc} bytes";
                    txtUrl.Text = duongDan;
                    txtSoDong.Text = DemSoDong(noiDung).ToString();
                    txtSoTu.Text = DemSoTu(noiDung).ToString();
                    txtSoKyTu.Text = noiDung.Length.ToString();
                    rtbThongTin.Text = noiDung;

                    lblTrangThai.Text = $"Đã tải: {tenFile}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static int DemSoDong(string noiDung)
        {
            if (noiDung.Length == 0)
            {
                return 0;
            }

            string chuanHoa = noiDung.Replace("\r\n", "\n").Replace('\r', '\n');
            int soDong = chuanHoa.Split('\n').Length;
            return chuanHoa.EndsWith("\n") ? soDong - 1 : soDong;
        }

        private static int DemSoTu(string noiDung) =>
            noiDung.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
