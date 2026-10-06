namespace NT106.R14._1_Lab02_25521506
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            tplBai = new TableLayoutPanel();
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            btnBai6 = new Button();
            btnBai7 = new Button();
            tplBai.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTieuDe.ForeColor = Color.FromArgb(15, 23, 42);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Padding = new Padding(32, 28, 0, 18);
            lblTieuDe.Size = new Size(560, 82);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Lab 02 - NT106";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tplBai
            // 
            tplBai.ColumnCount = 2;
            tplBai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tplBai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tplBai.Controls.Add(btnBai1, 0, 0);
            tplBai.Controls.Add(btnBai2, 1, 0);
            tplBai.Controls.Add(btnBai3, 0, 1);
            tplBai.Controls.Add(btnBai4, 1, 1);
            tplBai.Controls.Add(btnBai5, 0, 2);
            tplBai.Controls.Add(btnBai6, 1, 2);
            tplBai.Controls.Add(btnBai7, 0, 3);
            tplBai.Dock = DockStyle.Fill;
            tplBai.Location = new Point(0, 82);
            tplBai.Margin = new Padding(0);
            tplBai.Name = "tplBai";
            tplBai.Padding = new Padding(32, 0, 32, 26);
            tplBai.RowCount = 5;
            tplBai.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tplBai.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tplBai.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tplBai.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tplBai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tplBai.Size = new Size(560, 266);
            tplBai.TabIndex = 1;
            // 
            // btnBai1
            // 
            btnBai1.BackColor = Color.FromArgb(37, 99, 235);
            btnBai1.Dock = DockStyle.Fill;
            btnBai1.FlatAppearance.BorderSize = 0;
            btnBai1.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 60, 180);
            btnBai1.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnBai1.FlatStyle = FlatStyle.Flat;
            btnBai1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai1.ForeColor = Color.White;
            btnBai1.Location = new Point(32, 0);
            btnBai1.Margin = new Padding(0, 0, 10, 10);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(250, 48);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = Color.FromArgb(241, 245, 249);
            btnBai2.Dock = DockStyle.Fill;
            btnBai2.Enabled = false;
            btnBai2.FlatAppearance.BorderSize = 0;
            btnBai2.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai2.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai2.FlatStyle = FlatStyle.Flat;
            btnBai2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai2.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai2.Location = new Point(292, 0);
            btnBai2.Margin = new Padding(10, 0, 0, 10);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(250, 48);
            btnBai2.TabIndex = 1;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = false;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = Color.FromArgb(241, 245, 249);
            btnBai3.Dock = DockStyle.Fill;
            btnBai3.Enabled = false;
            btnBai3.FlatAppearance.BorderSize = 0;
            btnBai3.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai3.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai3.FlatStyle = FlatStyle.Flat;
            btnBai3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai3.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai3.Location = new Point(32, 68);
            btnBai3.Margin = new Padding(0, 0, 10, 10);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(250, 48);
            btnBai3.TabIndex = 2;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            // 
            // btnBai4
            // 
            btnBai4.BackColor = Color.FromArgb(241, 245, 249);
            btnBai4.Dock = DockStyle.Fill;
            btnBai4.Enabled = false;
            btnBai4.FlatAppearance.BorderSize = 0;
            btnBai4.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai4.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai4.FlatStyle = FlatStyle.Flat;
            btnBai4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai4.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai4.Location = new Point(292, 68);
            btnBai4.Margin = new Padding(10, 0, 0, 10);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(250, 48);
            btnBai4.TabIndex = 3;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = false;
            // 
            // btnBai5
            // 
            btnBai5.BackColor = Color.FromArgb(241, 245, 249);
            btnBai5.Dock = DockStyle.Fill;
            btnBai5.Enabled = false;
            btnBai5.FlatAppearance.BorderSize = 0;
            btnBai5.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai5.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai5.FlatStyle = FlatStyle.Flat;
            btnBai5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai5.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai5.Location = new Point(32, 136);
            btnBai5.Margin = new Padding(0, 0, 10, 10);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(250, 48);
            btnBai5.TabIndex = 4;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = false;
            // 
            // btnBai6
            // 
            btnBai6.BackColor = Color.FromArgb(241, 245, 249);
            btnBai6.Dock = DockStyle.Fill;
            btnBai6.Enabled = false;
            btnBai6.FlatAppearance.BorderSize = 0;
            btnBai6.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai6.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai6.FlatStyle = FlatStyle.Flat;
            btnBai6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai6.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai6.Location = new Point(292, 136);
            btnBai6.Margin = new Padding(10, 0, 0, 10);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(250, 48);
            btnBai6.TabIndex = 5;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = false;
            // 
            // btnBai7
            // 
            btnBai7.BackColor = Color.FromArgb(241, 245, 249);
            btnBai7.Dock = DockStyle.Fill;
            btnBai7.Enabled = false;
            btnBai7.FlatAppearance.BorderSize = 0;
            btnBai7.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai7.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai7.FlatStyle = FlatStyle.Flat;
            btnBai7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai7.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai7.Location = new Point(32, 204);
            btnBai7.Margin = new Padding(0, 0, 10, 10);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(250, 48);
            btnBai7.TabIndex = 6;
            btnBai7.Text = "Bài 7";
            btnBai7.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(560, 348);
            Controls.Add(tplBai);
            Controls.Add(lblTieuDe);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02 Menu";
            tplBai.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private TableLayoutPanel tplBai;
        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;
        private Button btnBai5;
        private Button btnBai6;
        private Button btnBai7;
    }
}