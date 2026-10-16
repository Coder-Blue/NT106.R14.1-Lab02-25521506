namespace NT106.R14._1_Lab02_25521506
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e) => new Lab02_Bai01().Show();

        private void btnBai2_Click(object sender, EventArgs e) => new Lab02_Bai02().Show();

        private void btnBai3_Click(object sender, EventArgs e) => new Lab02_Bai03().Show();

        private void btnBai4_Click(object sender, EventArgs e) => new Lab02_Bai04().Show();

        private void btnBai5_Click(object sender, EventArgs e) => new Lab02_Bai05().Show();
    }
}
