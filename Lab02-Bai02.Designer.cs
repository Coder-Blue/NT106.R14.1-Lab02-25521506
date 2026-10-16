namespace NT106.R14._1_Lab02_25521506
{
    partial class Lab02_Bai02
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
            tlpThongTin = new TableLayoutPanel();
            lblTenFile = new Label();
            txtTenFile = new TextBox();
            lblKichThuoc = new Label();
            txtKichThuoc = new TextBox();
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblSoDong = new Label();
            txtSoDong = new TextBox();
            lblSoTu = new Label();
            txtSoTu = new TextBox();
            lblSoKyTu = new Label();
            txtSoKyTu = new TextBox();
            btnDocFile = new Button();
            lblTieuDe = new Label();
            rtbThongTin = new RichTextBox();
            pnlBen.SuspendLayout();
            tlpThongTin.SuspendLayout();
            SuspendLayout();
            pnlBen.Controls.Add(lblTrangThai);
            pnlBen.Controls.Add(tlpThongTin);
            pnlBen.Controls.Add(btnDocFile);
            pnlBen.Controls.Add(lblTieuDe);
            pnlBen.Dock = DockStyle.Left;
            pnlBen.Location = new Point(0, 0);
            pnlBen.Name = "pnlBen";
            pnlBen.Padding = new Padding(12);
            pnlBen.Size = new Size(320, 500);
            pnlBen.TabIndex = 0;
            lblTrangThai.Dock = DockStyle.Bottom;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(12, 456);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(296, 32);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Chưa chọn file";
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpThongTin.Controls.Add(lblTenFile, 0, 0);
            tlpThongTin.Controls.Add(txtTenFile, 1, 0);
            tlpThongTin.Controls.Add(lblKichThuoc, 0, 1);
            tlpThongTin.Controls.Add(txtKichThuoc, 1, 1);
            tlpThongTin.Controls.Add(lblUrl, 0, 2);
            tlpThongTin.Controls.Add(txtUrl, 1, 2);
            tlpThongTin.Controls.Add(lblSoDong, 0, 3);
            tlpThongTin.Controls.Add(txtSoDong, 1, 3);
            tlpThongTin.Controls.Add(lblSoTu, 0, 4);
            tlpThongTin.Controls.Add(txtSoTu, 1, 4);
            tlpThongTin.Controls.Add(lblSoKyTu, 0, 5);
            tlpThongTin.Controls.Add(txtSoKyTu, 1, 5);
            tlpThongTin.Dock = DockStyle.Top;
            tlpThongTin.Location = new Point(12, 96);
            tlpThongTin.Margin = new Padding(0);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 6;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpThongTin.Size = new Size(296, 215);
            tlpThongTin.TabIndex = 2;
            lblTenFile.Dock = DockStyle.Fill;
            lblTenFile.Location = new Point(3, 0);
            lblTenFile.Name = "lblTenFile";
            lblTenFile.Size = new Size(89, 35);
            lblTenFile.TabIndex = 0;
            lblTenFile.Text = "Tên file:";
            lblTenFile.TextAlign = ContentAlignment.MiddleLeft;
            txtTenFile.Dock = DockStyle.Fill;
            txtTenFile.Location = new Point(98, 6);
            txtTenFile.Margin = new Padding(3, 6, 3, 3);
            txtTenFile.Name = "txtTenFile";
            txtTenFile.ReadOnly = true;
            txtTenFile.Size = new Size(195, 23);
            txtTenFile.TabIndex = 1;
            lblKichThuoc.Dock = DockStyle.Fill;
            lblKichThuoc.Location = new Point(3, 35);
            lblKichThuoc.Name = "lblKichThuoc";
            lblKichThuoc.Size = new Size(89, 35);
            lblKichThuoc.TabIndex = 2;
            lblKichThuoc.Text = "Kích thước:";
            lblKichThuoc.TextAlign = ContentAlignment.MiddleLeft;
            txtKichThuoc.Dock = DockStyle.Fill;
            txtKichThuoc.Location = new Point(98, 41);
            txtKichThuoc.Margin = new Padding(3, 6, 3, 3);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.ReadOnly = true;
            txtKichThuoc.Size = new Size(195, 23);
            txtKichThuoc.TabIndex = 3;
            lblUrl.Dock = DockStyle.Fill;
            lblUrl.Location = new Point(3, 70);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(89, 35);
            lblUrl.TabIndex = 4;
            lblUrl.Text = "URL:";
            lblUrl.TextAlign = ContentAlignment.MiddleLeft;
            txtUrl.Dock = DockStyle.Fill;
            txtUrl.Location = new Point(98, 76);
            txtUrl.Margin = new Padding(3, 6, 3, 3);
            txtUrl.Name = "txtUrl";
            txtUrl.ReadOnly = true;
            txtUrl.Size = new Size(195, 23);
            txtUrl.TabIndex = 5;
            lblSoDong.Dock = DockStyle.Fill;
            lblSoDong.Location = new Point(3, 105);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Size = new Size(89, 35);
            lblSoDong.TabIndex = 6;
            lblSoDong.Text = "Số dòng:";
            lblSoDong.TextAlign = ContentAlignment.MiddleLeft;
            txtSoDong.Dock = DockStyle.Fill;
            txtSoDong.Location = new Point(98, 111);
            txtSoDong.Margin = new Padding(3, 6, 3, 3);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.ReadOnly = true;
            txtSoDong.Size = new Size(195, 23);
            txtSoDong.TabIndex = 7;
            lblSoTu.Dock = DockStyle.Fill;
            lblSoTu.Location = new Point(3, 140);
            lblSoTu.Name = "lblSoTu";
            lblSoTu.Size = new Size(89, 35);
            lblSoTu.TabIndex = 8;
            lblSoTu.Text = "Số từ:";
            lblSoTu.TextAlign = ContentAlignment.MiddleLeft;
            txtSoTu.Dock = DockStyle.Fill;
            txtSoTu.Location = new Point(98, 146);
            txtSoTu.Margin = new Padding(3, 6, 3, 3);
            txtSoTu.Name = "txtSoTu";
            txtSoTu.ReadOnly = true;
            txtSoTu.Size = new Size(195, 23);
            txtSoTu.TabIndex = 9;
            lblSoKyTu.Dock = DockStyle.Fill;
            lblSoKyTu.Location = new Point(3, 175);
            lblSoKyTu.Name = "lblSoKyTu";
            lblSoKyTu.Size = new Size(89, 40);
            lblSoKyTu.TabIndex = 10;
            lblSoKyTu.Text = "Số ký tự:";
            lblSoKyTu.TextAlign = ContentAlignment.MiddleLeft;
            txtSoKyTu.Dock = DockStyle.Fill;
            txtSoKyTu.Location = new Point(98, 181);
            txtSoKyTu.Margin = new Padding(3, 6, 3, 3);
            txtSoKyTu.Name = "txtSoKyTu";
            txtSoKyTu.ReadOnly = true;
            txtSoKyTu.Size = new Size(195, 23);
            txtSoKyTu.TabIndex = 11;
            btnDocFile.Dock = DockStyle.Top;
            btnDocFile.Location = new Point(12, 51);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(296, 45);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(12, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(0, 0, 0, 12);
            lblTieuDe.Size = new Size(197, 39);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 2 - Đọc thông tin file .txt";
            rtbThongTin.Dock = DockStyle.Fill;
            rtbThongTin.Location = new Point(320, 0);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.ReadOnly = true;
            rtbThongTin.Size = new Size(560, 500);
            rtbThongTin.TabIndex = 1;
            rtbThongTin.Text = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 500);
            Controls.Add(rtbThongTin);
            Controls.Add(pnlBen);
            Name = "Lab02_Bai02";
            Text = "Bài 2 - Đọc thông tin một file .txt";
            pnlBen.ResumeLayout(false);
            pnlBen.PerformLayout();
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBen;
        private Label lblTieuDe;
        private Button btnDocFile;
        private TableLayoutPanel tlpThongTin;
        private Label lblTenFile;
        private TextBox txtTenFile;
        private Label lblKichThuoc;
        private TextBox txtKichThuoc;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblSoDong;
        private TextBox txtSoDong;
        private Label lblSoTu;
        private TextBox txtSoTu;
        private Label lblSoKyTu;
        private TextBox txtSoKyTu;
        private Label lblTrangThai;
        private RichTextBox rtbThongTin;
    }
}