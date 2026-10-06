namespace NT106.R14._1_Lab02_25521506
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            // Show the child window as a dialog so it stays on top of the menu
            // and only one copy can be open at a time.
            using (Lab02_Bai01 form = new Lab02_Bai01())
            {
                form.ShowDialog(this);
            }
        }
    }
}