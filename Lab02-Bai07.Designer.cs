namespace NT106.R14._1_Lab02_25521506
{
    partial class Lab02_Bai07
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
            lblTieuDe = new Label();
            grpDuongDan = new GroupBox();
            btnTaiLai = new Button();
            btnLen = new Button();
            btnDi = new Button();
            txtDuongDan = new TextBox();
            lblDuongDan = new Label();
            cmbODia = new ComboBox();
            lblODia = new Label();
            grpDanhSach = new GroupBox();
            lvDanhSach = new ListView();
            colTen = new ColumnHeader();
            colLoai = new ColumnHeader();
            colKichThuoc = new ColumnHeader();
            colSuaDoi = new ColumnHeader();
            grpNoiDung = new GroupBox();
            rtbNoiDung = new RichTextBox();
            lblThongTinFile = new Label();
            lblTrangThai = new Label();
            grpDuongDan.SuspendLayout();
            grpDanhSach.SuspendLayout();
            grpNoiDung.SuspendLayout();
            SuspendLayout();
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(12, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(12, 12, 0, 12);
            lblTieuDe.Size = new Size(171, 42);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 7 - Duyệt thư mục";
            grpDuongDan.Controls.Add(btnTaiLai);
            grpDuongDan.Controls.Add(btnLen);
            grpDuongDan.Controls.Add(btnDi);
            grpDuongDan.Controls.Add(txtDuongDan);
            grpDuongDan.Controls.Add(lblDuongDan);
            grpDuongDan.Controls.Add(cmbODia);
            grpDuongDan.Controls.Add(lblODia);
            grpDuongDan.Location = new Point(15, 48);
            grpDuongDan.Name = "grpDuongDan";
            grpDuongDan.Size = new Size(950, 80);
            grpDuongDan.TabIndex = 1;
            grpDuongDan.TabStop = false;
            grpDuongDan.Text = "Đường dẫn";
            btnTaiLai.Location = new Point(873, 27);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(65, 25);
            btnTaiLai.TabIndex = 6;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            btnLen.Location = new Point(793, 27);
            btnLen.Name = "btnLen";
            btnLen.Size = new Size(75, 25);
            btnLen.TabIndex = 5;
            btnLen.Text = "Lên trên";
            btnLen.UseVisualStyleBackColor = true;
            btnLen.Click += btnLen_Click;
            btnDi.Location = new Point(733, 27);
            btnDi.Name = "btnDi";
            btnDi.Size = new Size(55, 25);
            btnDi.TabIndex = 4;
            btnDi.Text = "Đi";
            btnDi.UseVisualStyleBackColor = true;
            btnDi.Click += btnDi_Click;
            txtDuongDan.Location = new Point(305, 27);
            txtDuongDan.Name = "txtDuongDan";
            txtDuongDan.Size = new Size(420, 23);
            txtDuongDan.TabIndex = 3;
            lblDuongDan.Location = new Point(222, 30);
            lblDuongDan.Name = "lblDuongDan";
            lblDuongDan.Size = new Size(80, 23);
            lblDuongDan.TabIndex = 2;
            lblDuongDan.Text = "Đường dẫn:";
            lblDuongDan.TextAlign = ContentAlignment.MiddleLeft;
            cmbODia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbODia.FormattingEnabled = true;
            cmbODia.Location = new Point(70, 27);
            cmbODia.Name = "cmbODia";
            cmbODia.Size = new Size(140, 23);
            cmbODia.TabIndex = 1;
            cmbODia.SelectedIndexChanged += cmbODia_SelectedIndexChanged;
            lblODia.Location = new Point(15, 30);
            lblODia.Name = "lblODia";
            lblODia.Size = new Size(50, 23);
            lblODia.TabIndex = 0;
            lblODia.Text = "Ổ đĩa:";
            lblODia.TextAlign = ContentAlignment.MiddleLeft;
            grpDanhSach.Controls.Add(lvDanhSach);
            grpDanhSach.Location = new Point(15, 135);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(600, 420);
            grpDanhSach.TabIndex = 2;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách file và thư mục";
            lvDanhSach.Columns.AddRange(new ColumnHeader[] { colTen, colLoai, colKichThuoc, colSuaDoi });
            lvDanhSach.FullRowSelect = true;
            lvDanhSach.GridLines = true;
            lvDanhSach.HideSelection = false;
            lvDanhSach.Location = new Point(15, 25);
            lvDanhSach.MultiSelect = false;
            lvDanhSach.Name = "lvDanhSach";
            lvDanhSach.Size = new Size(570, 385);
            lvDanhSach.TabIndex = 0;
            lvDanhSach.UseCompatibleStateImageBehavior = false;
            lvDanhSach.View = View.Details;
            lvDanhSach.SelectedIndexChanged += lvDanhSach_SelectedIndexChanged;
            lvDanhSach.DoubleClick += lvDanhSach_DoubleClick;
            colTen.Text = "Tên";
            colTen.Width = 250;
            colLoai.Text = "Loại";
            colLoai.Width = 90;
            colKichThuoc.Text = "Kích thước";
            colKichThuoc.Width = 100;
            colSuaDoi.Text = "Sửa đổi";
            colSuaDoi.Width = 125;
            grpNoiDung.Controls.Add(rtbNoiDung);
            grpNoiDung.Controls.Add(lblThongTinFile);
            grpNoiDung.Location = new Point(625, 135);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Size = new Size(340, 420);
            grpNoiDung.TabIndex = 3;
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "Nội dung file";
            rtbNoiDung.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbNoiDung.Location = new Point(15, 90);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.ScrollBars = RichTextBoxScrollBars.Both;
            rtbNoiDung.Size = new Size(310, 320);
            rtbNoiDung.TabIndex = 1;
            rtbNoiDung.Text = "";
            rtbNoiDung.WordWrap = false;
            lblThongTinFile.Location = new Point(15, 30);
            lblThongTinFile.Name = "lblThongTinFile";
            lblThongTinFile.Size = new Size(310, 55);
            lblThongTinFile.TabIndex = 0;
            lblThongTinFile.Text = "Chưa chọn file nào";
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(15, 565);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(950, 25);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Sẵn sàng";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 600);
            Controls.Add(lblTrangThai);
            Controls.Add(grpNoiDung);
            Controls.Add(grpDanhSach);
            Controls.Add(grpDuongDan);
            Controls.Add(lblTieuDe);
            Name = "Lab02_Bai07";
            Padding = new Padding(12);
            Text = "Bài 7 - Duyệt thư mục";
            grpDuongDan.ResumeLayout(false);
            grpDuongDan.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpDuongDan;
        private Label lblODia;
        private ComboBox cmbODia;
        private Label lblDuongDan;
        private TextBox txtDuongDan;
        private Button btnDi;
        private Button btnLen;
        private Button btnTaiLai;
        private GroupBox grpDanhSach;
        private ListView lvDanhSach;
        private ColumnHeader colTen;
        private ColumnHeader colLoai;
        private ColumnHeader colKichThuoc;
        private ColumnHeader colSuaDoi;
        private GroupBox grpNoiDung;
        private Label lblThongTinFile;
        private RichTextBox rtbNoiDung;
        private Label lblTrangThai;
    }
}
