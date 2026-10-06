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
            lblTieuDe = new Label();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            rtbThongTin = new RichTextBox();
            lblTrangThai = new Label();
            pnlBen.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBen
            // 
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
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(0, 0, 0, 12);
            lblTieuDe.Size = new Size(174, 39);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Bài 1 - Ghi và Đọc File";
            // 
            // btnDocFile
            // 
            btnDocFile.Dock = DockStyle.Top;
            btnDocFile.Location = new Point(0, 39);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(174, 45);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Dock = DockStyle.Top;
            btnGhiFile.Location = new Point(0, 84);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(174, 45);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "Ghi file";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = DockStyle.Bottom;
            lblTrangThai.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Location = new Point(0, 456);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(174, 32);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "input1.txt → output1.txt";
            // 
            // rtbThongTin
            // 
            rtbThongTin.Dock = DockStyle.Fill;
            rtbThongTin.Location = new Point(200, 0);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.Size = new Size(620, 500);
            rtbThongTin.TabIndex = 1;
            rtbThongTin.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 500);
            Controls.Add(rtbThongTin);
            Controls.Add(pnlBen);
            Name = "Lab02_Bai01";
            Text = "Bài 1 - Ghi và Đọc File";
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