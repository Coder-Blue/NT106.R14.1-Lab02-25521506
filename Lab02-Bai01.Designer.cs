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
            rtbThongTin = new RichTextBox();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            SuspendLayout();
            // 
            // rtbThongTin
            // 
            rtbThongTin.Location = new Point(294, 34);
            rtbThongTin.Name = "rtbThongTin";
            rtbThongTin.Size = new Size(583, 549);
            rtbThongTin.TabIndex = 0;
            rtbThongTin.Text = "";
            // 
            // btnDocFile
            // 
            btnDocFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDocFile.Location = new Point(33, 34);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(207, 76);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnGhiFile.Location = new Point(33, 161);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(207, 66);
            btnGhiFile.TabIndex = 2;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 615);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(rtbThongTin);
            Name = "Lab02_Bai01";
            Text = "Ghi và Đọc File";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbThongTin;
        private Button btnDocFile;
        private Button btnGhiFile;
    }
}