using System;
using System.IO;
using System.Windows.Forms;

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

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy tên file thông qua SafeFileName của OpenFileDialog
                        string fileName = ofd.SafeFileName;

                        // Mở luồng đọc FileStream và sử dụng StreamReader
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            // Lấy URL / đường dẫn thông qua Name của FileStream
                            string url = fs.Name;
                            long fileSize = fs.Length;

                            string content;
                            using (StreamReader sr = new StreamReader(fs))
                            {
                                content = sr.ReadToEnd();
                            }

                            // Đếm số dòng, số từ, số ký tự
                            int lineCount = 0;
                            int wordCount = 0;
                            int charCount = content.Length;

                            if (!string.IsNullOrEmpty(content))
                            {
                                using (StringReader strReader = new StringReader(content))
                                {
                                    while (strReader.ReadLine() != null)
                                    {
                                        lineCount++;
                                    }
                                }

                                string[] words = content.Split(
                                    new char[] { ' ', '\t', '\r', '\n' },
                                    StringSplitOptions.RemoveEmptyEntries
                                );
                                wordCount = words.Length;
                            }

                            // Hiển thị thông tin lên giao diện
                            txtTenFile.Text = fileName;
                            txtKichThuoc.Text = $"{fileSize} bytes";
                            txtUrl.Text = url;
                            txtSoDong.Text = lineCount.ToString();
                            txtSoTu.Text = wordCount.ToString();
                            txtSoKyTu.Text = charCount.ToString();
                            rtbThongTin.Text = content;

                            lblTrangThai.Text = $"Đã tải: {fileName}";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
