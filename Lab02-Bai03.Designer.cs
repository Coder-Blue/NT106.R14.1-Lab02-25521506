namespace NT106.R14._1_Lab02_25521506
{
    partial class Lab02_Bai03
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlBen = new Panel();
            lblTrangThai = new Label();
            btnGhiFile = new Button();
            btnDocFile = new Button();
            lblTieuDe = new Label();
            rtbThongTin = new RichTextBox();
            pnlBen.SuspendLayout();
            SuspendLayout();
            pnlBen.Controls.Add(lblTrangThai);
            pnlBen.Controls.Add(btnGhiFile);
            pnlBen.Controls.Add(btnDocFile);
            pnlBen.Controls.Add(lblTieuDe);
            pnlBen.Dock = DockStyle.Left;
            pnlBen.Location = new Point(0, 0);
            pnlBen.Name = "pnlBen";
            pnlBen.Padding = new Padding(12);
            pnlBen.Size = new Size(200, 500);
            pnlBen.TabIndex = 0;
            lblTrangThai.Dock = DockStyle.Bottom;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(12, 456);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(176, 32);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "input3.txt → output3.txt";
            btnGhiFile.Dock = DockStyle.Top;
            btnGhiFile.Location = new Point(12, 96);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(176, 45);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "Ghi file (output3.txt)";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            btnDocFile.Dock = DockStyle.Top;
            btnDocFile.Location = new Point(12, 51);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(176, 45);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "Đọc file (input3.txt)";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(12, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(0, 0, 0, 12);
            lblTieuDe.Size = new Size(174, 39);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 3 - Đọc, Ghi & Tính toán";
            rtbThongTin.Dock = DockStyle.Fill;
            rtbThongTin.Location = new Point(200, 0);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.ReadOnly = true;
            rtbThongTin.Size = new Size(620, 500);
            rtbThongTin.TabIndex = 1;
            rtbThongTin.Text = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 500);
            Controls.Add(rtbThongTin);
            Controls.Add(pnlBen);
            Name = "Lab02_Bai03";
            Text = "Bài 3 - Đọc và Ghi file và tính toán";
            pnlBen.ResumeLayout(false);
            pnlBen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBen;
        private Label lblTieuDe;
        private Button btnDocFile;
        private Button btnGhiFile;
        private RichTextBox rtbThongTin;
        private Label lblTrangThai;
    }
}
