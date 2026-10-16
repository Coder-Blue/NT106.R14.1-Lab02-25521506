namespace NT106.R14._1_Lab02_25521506
{
    partial class Lab02_Bai06
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
            grpDanhSach = new GroupBox();
            lvMonAn = new ListView();
            colMa = new ColumnHeader();
            colTen = new ColumnHeader();
            colNguoi = new ColumnHeader();
            btnXoaMonAn = new Button();
            grpThemMonAn = new GroupBox();
            btnThemMonAn = new Button();
            btnChonHinh = new Button();
            txtHinhAnh = new TextBox();
            lblHinhAnh = new Label();
            cmbNguoiDung = new ComboBox();
            lblNguoiDongGop = new Label();
            txtTenMonAn = new TextBox();
            lblTenMonAn = new Label();
            grpKetQua = new GroupBox();
            lblKetQua = new Label();
            picMonAn = new PictureBox();
            btnAnGi = new Button();
            lblTrangThai = new Label();
            grpDanhSach.SuspendLayout();
            grpThemMonAn.SuspendLayout();
            grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(12, 12, 0, 12);
            lblTieuDe.Size = new Size(361, 42);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 6 - Hôm nay ăn gì? (phiên bản số 2)";
            grpDanhSach.Controls.Add(lvMonAn);
            grpDanhSach.Controls.Add(btnXoaMonAn);
            grpDanhSach.Location = new Point(15, 48);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(470, 520);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách món ăn (từ cơ sở dữ liệu SQLite)";
            lvMonAn.Columns.AddRange(new ColumnHeader[] { colMa, colTen, colNguoi });
            lvMonAn.FullRowSelect = true;
            lvMonAn.GridLines = true;
            lvMonAn.Location = new Point(15, 25);
            lvMonAn.MultiSelect = false;
            lvMonAn.Name = "lvMonAn";
            lvMonAn.Size = new Size(440, 445);
            lvMonAn.TabIndex = 0;
            lvMonAn.UseCompatibleStateImageBehavior = false;
            lvMonAn.View = View.Details;
            colMa.Text = "Mã";
            colMa.Width = 60;
            colTen.Text = "Tên món ăn";
            colTen.Width = 170;
            colNguoi.Text = "Người đóng góp";
            colNguoi.Width = 200;
            btnXoaMonAn.Location = new Point(15, 478);
            btnXoaMonAn.Name = "btnXoaMonAn";
            btnXoaMonAn.Size = new Size(440, 32);
            btnXoaMonAn.TabIndex = 1;
            btnXoaMonAn.Text = "Xoá món ăn đang chọn";
            btnXoaMonAn.UseVisualStyleBackColor = true;
            btnXoaMonAn.Click += btnXoaMonAn_Click;
            grpThemMonAn.Controls.Add(btnThemMonAn);
            grpThemMonAn.Controls.Add(btnChonHinh);
            grpThemMonAn.Controls.Add(txtHinhAnh);
            grpThemMonAn.Controls.Add(lblHinhAnh);
            grpThemMonAn.Controls.Add(cmbNguoiDung);
            grpThemMonAn.Controls.Add(lblNguoiDongGop);
            grpThemMonAn.Controls.Add(txtTenMonAn);
            grpThemMonAn.Controls.Add(lblTenMonAn);
            grpThemMonAn.Location = new Point(500, 48);
            grpThemMonAn.Name = "grpThemMonAn";
            grpThemMonAn.Size = new Size(470, 220);
            grpThemMonAn.TabIndex = 2;
            grpThemMonAn.TabStop = false;
            grpThemMonAn.Text = "Thêm món ăn";
            btnThemMonAn.Location = new Point(15, 140);
            btnThemMonAn.Name = "btnThemMonAn";
            btnThemMonAn.Size = new Size(440, 34);
            btnThemMonAn.TabIndex = 7;
            btnThemMonAn.Text = "Thêm món ăn";
            btnThemMonAn.UseVisualStyleBackColor = true;
            btnThemMonAn.Click += btnThemMonAn_Click;
            btnChonHinh.Location = new Point(370, 97);
            btnChonHinh.Name = "btnChonHinh";
            btnChonHinh.Size = new Size(85, 25);
            btnChonHinh.TabIndex = 6;
            btnChonHinh.Text = "Chọn...";
            btnChonHinh.UseVisualStyleBackColor = true;
            btnChonHinh.Click += btnChonHinh_Click;
            txtHinhAnh.Location = new Point(120, 97);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(245, 23);
            txtHinhAnh.TabIndex = 5;
            lblHinhAnh.Location = new Point(15, 100);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(100, 23);
            lblHinhAnh.TabIndex = 4;
            lblHinhAnh.Text = "Hình ảnh:";
            lblHinhAnh.TextAlign = ContentAlignment.MiddleLeft;
            cmbNguoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNguoiDung.FormattingEnabled = true;
            cmbNguoiDung.Location = new Point(120, 62);
            cmbNguoiDung.Name = "cmbNguoiDung";
            cmbNguoiDung.Size = new Size(335, 23);
            cmbNguoiDung.TabIndex = 3;
            lblNguoiDongGop.Location = new Point(15, 65);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(100, 23);
            lblNguoiDongGop.TabIndex = 2;
            lblNguoiDongGop.Text = "Người đóng góp:";
            lblNguoiDongGop.TextAlign = ContentAlignment.MiddleLeft;
            txtTenMonAn.Location = new Point(120, 27);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(335, 23);
            txtTenMonAn.TabIndex = 1;
            lblTenMonAn.Location = new Point(15, 30);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(100, 23);
            lblTenMonAn.TabIndex = 0;
            lblTenMonAn.Text = "Tên món ăn:";
            lblTenMonAn.TextAlign = ContentAlignment.MiddleLeft;
            grpKetQua.Controls.Add(lblKetQua);
            grpKetQua.Controls.Add(picMonAn);
            grpKetQua.Controls.Add(btnAnGi);
            grpKetQua.Location = new Point(500, 280);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Size = new Size(470, 288);
            grpKetQua.TabIndex = 3;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "Kết quả";
            lblKetQua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetQua.Location = new Point(250, 80);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(205, 185);
            lblKetQua.TabIndex = 2;
            lblKetQua.Text = "Chưa chọn món ăn nào";
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(15, 80);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(220, 185);
            picMonAn.SizeMode = PictureBoxSizeMode.Zoom;
            picMonAn.TabIndex = 1;
            picMonAn.TabStop = false;
            btnAnGi.Location = new Point(15, 25);
            btnAnGi.Name = "btnAnGi";
            btnAnGi.Size = new Size(440, 40);
            btnAnGi.TabIndex = 0;
            btnAnGi.Text = "Hôm nay ăn gì?";
            btnAnGi.UseVisualStyleBackColor = true;
            btnAnGi.Click += btnAnGi_Click;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(15, 578);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(955, 25);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Sẵn sàng";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 615);
            Controls.Add(lblTrangThai);
            Controls.Add(grpKetQua);
            Controls.Add(grpThemMonAn);
            Controls.Add(grpDanhSach);
            Controls.Add(lblTieuDe);
            Name = "Lab02_Bai06";
            Padding = new Padding(12);
            Text = "Bài 6 - Hôm nay ăn gì? (phiên bản số 2)";
            grpDanhSach.ResumeLayout(false);
            grpThemMonAn.ResumeLayout(false);
            grpThemMonAn.PerformLayout();
            grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpDanhSach;
        private ListView lvMonAn;
        private ColumnHeader colMa;
        private ColumnHeader colTen;
        private ColumnHeader colNguoi;
        private Button btnXoaMonAn;
        private GroupBox grpThemMonAn;
        private Label lblTenMonAn;
        private TextBox txtTenMonAn;
        private Label lblNguoiDongGop;
        private ComboBox cmbNguoiDung;
        private Label lblHinhAnh;
        private TextBox txtHinhAnh;
        private Button btnChonHinh;
        private Button btnThemMonAn;
        private GroupBox grpKetQua;
        private Button btnAnGi;
        private PictureBox picMonAn;
        private Label lblKetQua;
        private Label lblTrangThai;
    }
}
