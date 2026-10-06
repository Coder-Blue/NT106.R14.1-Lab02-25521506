namespace NT106.R14._1_Lab02_25521506
{
    partial class Lab02_Bai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            tplSidebar = new TableLayoutPanel();
            lblBai = new Label();
            lblMoTa = new Label();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            lblTrangThai = new Label();
            pnlNoiDung = new Panel();
            tplNoiDung = new TableLayoutPanel();
            lblTieuDe = new Label();
            rtbThongTin = new RichTextBox();
            tblRoot = new TableLayoutPanel();
            pnlSidebar.SuspendLayout();
            tplSidebar.SuspendLayout();
            pnlNoiDung.SuspendLayout();
            tplNoiDung.SuspendLayout();
            tblRoot.SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(tplSidebar);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(24, 24, 24, 20);
            pnlSidebar.Size = new Size(260, 620);
            pnlSidebar.TabIndex = 0;
            // 
            // tplSidebar
            // 
            tplSidebar.ColumnCount = 1;
            tplSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplSidebar.Controls.Add(lblBai, 0, 0);
            tplSidebar.Controls.Add(lblMoTa, 0, 1);
            tplSidebar.Controls.Add(btnDocFile, 0, 2);
            tplSidebar.Controls.Add(btnGhiFile, 0, 3);
            tplSidebar.Controls.Add(lblTrangThai, 0, 4);
            tplSidebar.Dock = DockStyle.Fill;
            tplSidebar.Location = new Point(24, 24);
            tplSidebar.Margin = new Padding(0);
            tplSidebar.Name = "tplSidebar";
            tplSidebar.RowCount = 5;
            tplSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tplSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tplSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tplSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tplSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tplSidebar.Size = new Size(212, 576);
            tplSidebar.TabIndex = 0;
            // 
            // lblBai
            // 
            lblBai.Dock = DockStyle.Fill;
            lblBai.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblBai.ForeColor = Color.FromArgb(15, 23, 42);
            lblBai.Location = new Point(0, 0);
            lblBai.Margin = new Padding(0, 0, 0, 0);
            lblBai.Name = "lblBai";
            lblBai.Size = new Size(212, 34);
            lblBai.TabIndex = 0;
            lblBai.Text = "Bài 1";
            lblBai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMoTa
            // 
            lblMoTa.Dock = DockStyle.Fill;
            lblMoTa.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoTa.ForeColor = Color.FromArgb(100, 116, 139);
            lblMoTa.Location = new Point(0, 34);
            lblMoTa.Margin = new Padding(0, 0, 0, 12);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(212, 40);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Ghi nội dung ra output1.txt và đọc nội dung từ input1.txt";
            lblMoTa.TextAlign = ContentAlignment.TopLeft;
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.FromArgb(37, 99, 235);
            btnDocFile.Dock = DockStyle.Fill;
            btnDocFile.FlatAppearance.BorderSize = 0;
            btnDocFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 60, 180);
            btnDocFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnDocFile.FlatStyle = FlatStyle.Flat;
            btnDocFile.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDocFile.ForeColor = Color.White;
            btnDocFile.Location = new Point(0, 86);
            btnDocFile.Margin = new Padding(0, 0, 0, 10);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(212, 46);
            btnDocFile.TabIndex = 2;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.BackColor = Color.White;
            btnGhiFile.Dock = DockStyle.Fill;
            btnGhiFile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnGhiFile.FlatAppearance.BorderSize = 1;
            btnGhiFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnGhiFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnGhiFile.FlatStyle = FlatStyle.Flat;
            btnGhiFile.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGhiFile.ForeColor = Color.FromArgb(15, 23, 42);
            btnGhiFile.Location = new Point(0, 142);
            btnGhiFile.Margin = new Padding(0, 0, 0, 10);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(212, 46);
            btnGhiFile.TabIndex = 3;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = false;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(148, 163, 184);
            lblTrangThai.Location = new Point(0, 198);
            lblTrangThai.Margin = new Padding(0, 12, 0, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(212, 378);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "0 ký tự · 0 dòng";
            lblTrangThai.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.BackColor = Color.FromArgb(244, 246, 249);
            pnlNoiDung.Controls.Add(tplNoiDung);
            pnlNoiDung.Dock = DockStyle.Fill;
            pnlNoiDung.Location = new Point(260, 0);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Padding = new Padding(24, 24, 24, 20);
            pnlNoiDung.Size = new Size(680, 620);
            pnlNoiDung.TabIndex = 1;
            // 
            // tplNoiDung
            // 
            tplNoiDung.ColumnCount = 1;
            tplNoiDung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplNoiDung.Controls.Add(lblTieuDe, 0, 0);
            tplNoiDung.Controls.Add(rtbThongTin, 0, 1);
            tplNoiDung.Dock = DockStyle.Fill;
            tplNoiDung.Location = new Point(24, 24);
            tplNoiDung.Margin = new Padding(0);
            tplNoiDung.Name = "tplNoiDung";
            tplNoiDung.RowCount = 2;
            tplNoiDung.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tplNoiDung.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tplNoiDung.Size = new Size(632, 576);
            tplNoiDung.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTieuDe.ForeColor = Color.FromArgb(15, 23, 42);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Margin = new Padding(0, 0, 0, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(632, 22);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Nội dung";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbThongTin
            // 
            rtbThongTin.BackColor = Color.White;
            rtbThongTin.BorderStyle = BorderStyle.None;
            rtbThongTin.Dock = DockStyle.Fill;
            rtbThongTin.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbThongTin.ForeColor = Color.FromArgb(15, 23, 42);
            rtbThongTin.HideSelection = false;
            rtbThongTin.Location = new Point(0, 30);
            rtbThongTin.Margin = new Padding(0);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.Size = new Size(632, 546);
            rtbThongTin.TabIndex = 1;
            rtbThongTin.Text = "";
            rtbThongTin.TextChanged += rtbThongTin_TextChanged;
            // 
            // tblRoot
            // 
            tblRoot.ColumnCount = 2;
            tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRoot.Controls.Add(pnlSidebar, 0, 0);
            tblRoot.Controls.Add(pnlNoiDung, 1, 0);
            tblRoot.Dock = DockStyle.Fill;
            tblRoot.Location = new Point(0, 0);
            tblRoot.Margin = new Padding(0);
            tblRoot.Name = "tblRoot";
            tblRoot.RowCount = 1;
            tblRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblRoot.Size = new Size(940, 620);
            tblRoot.TabIndex = 0;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(940, 620);
            Controls.Add(tblRoot);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Lab02_Bai01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 1 - Ghi và Đọc File";
            pnlSidebar.ResumeLayout(false);
            tplSidebar.ResumeLayout(false);
            pnlNoiDung.ResumeLayout(false);
            tplNoiDung.ResumeLayout(false);
            tblRoot.ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private TableLayoutPanel tplSidebar;
        private Label lblBai;
        private Label lblMoTa;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Label lblTrangThai;
        private Panel pnlNoiDung;
        private TableLayoutPanel tplNoiDung;
        private Label lblTieuDe;
        private RichTextBox rtbThongTin;
        private TableLayoutPanel tblRoot;
    }
}