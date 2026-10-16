namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input1.txt"))
            {
                MessageBox.Show("Chưa tạo file input1.txt");
                return;
            }

            rtbThongTin.Text = File.ReadAllText("input1.txt");
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText("output1.txt", rtbThongTin.Text.ToUpper());
            rtbThongTin.Text = File.ReadAllText("output1.txt");
            MessageBox.Show("Đã ghi xong");
        }
    }
}
