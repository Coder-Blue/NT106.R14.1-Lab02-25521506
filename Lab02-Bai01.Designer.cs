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
            pnlBen = new Panel();
            tplBen = new TableLayoutPanel();
            lblTieuDe = new Label();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            pnlTrong = new Panel();
            rtbThongTin = new RichTextBox();
            pnlBen.SuspendLayout();
            tplBen.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBen
            // 
            pnlBen.BackColor = Color.White;
            pnlBen.Controls.Add(tplBen);
            pnlBen.Dock = DockStyle.Left;
            pnlBen.Location = new Point(0, 0);
            pnlBen.Name = "pnlBen";
            pnlBen.Padding = new Padding(24, 24, 24, 24);
            pnlBen.Size = new Size(250, 540);
            pnlBen.TabIndex = 0;
            // 
            // tplBen
            // 
            tplBen.ColumnCount = 1;
            tplBen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplBen.Controls.Add(lblTieuDe, 0, 0);
            tplBen.Controls.Add(btnDocFile, 0, 1);
            tplBen.Controls.Add(btnGhiFile, 0, 2);
            tplBen.Controls.Add(pnlTrong, 0, 3);
            tplBen.Dock = DockStyle.Fill;
            tplBen.Location = new Point(24, 24);
            tplBen.Margin = new Padding(0);
            tplBen.Name = "tplBen";
            tplBen.RowCount = 4;
            tplBen.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tplBen.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tplBen.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tplBen.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tplBen.Size = new Size(202, 492);
            tplBen.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTieuDe.ForeColor = Color.FromArgb(15, 23, 42);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Margin = new Padding(0, 0, 0, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(202, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 1";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.FromArgb(37, 99, 235);
            btnDocFile.Dock = DockStyle.Fill;
            btnDocFile.FlatAppearance.BorderSize = 0;
            btnDocFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 60, 180);
            btnDocFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnDocFile.FlatStyle = FlatStyle.Flat;
            btnDocFile.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDocFile.ForeColor = Color.White;
            btnDocFile.Location = new Point(0, 50);
            btnDocFile.Margin = new Padding(0, 0, 0, 10);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(202, 34);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = false;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.BackColor = Color.White;
            btnGhiFile.Dock = DockStyle.Fill;
            btnGhiFile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnGhiFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnGhiFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnGhiFile.FlatStyle = FlatStyle.Flat;
            btnGhiFile.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGhiFile.ForeColor = Color.FromArgb(15, 23, 42);
            btnGhiFile.Location = new Point(0, 94);
            btnGhiFile.Margin = new Padding(0);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(202, 44);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = false;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // pnlTrong
            // 
            pnlTrong.Dock = DockStyle.Fill;
            pnlTrong.Location = new Point(0, 138);
            pnlTrong.Margin = new Padding(0);
            pnlTrong.Name = "pnlTrong";
            pnlTrong.Size = new Size(202, 354);
            pnlTrong.TabIndex = 3;
            // 
            // rtbThongTin
            // 
            rtbThongTin.BackColor = Color.White;
            rtbThongTin.Dock = DockStyle.Fill;
            rtbThongTin.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbThongTin.ForeColor = Color.FromArgb(15, 23, 42);
            rtbThongTin.Location = new Point(250, 0);
            rtbThongTin.Margin = new Padding(0);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.Size = new Size(630, 540);
            rtbThongTin.TabIndex = 1;
            rtbThongTin.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(880, 540);
            Controls.Add(rtbThongTin);
            Controls.Add(pnlBen);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Lab02_Bai01";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 1 - Ghi và Đọc File";
            pnlBen.ResumeLayout(false);
            tplBen.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBen;
        private TableLayoutPanel tplBen;
        private Label lblTieuDe;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Panel pnlTrong;
        private RichTextBox rtbThongTin;
    }
}