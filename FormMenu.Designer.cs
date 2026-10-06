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
            tplRoot = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            tplGrid = new TableLayoutPanel();
            cell1 = new Panel();
            btnBai1 = new Button();
            lblDesc1 = new Label();
            cell2 = new Panel();
            btnBai2 = new Button();
            lblDesc2 = new Label();
            cell3 = new Panel();
            btnBai3 = new Button();
            lblDesc3 = new Label();
            cell4 = new Panel();
            btnBai4 = new Button();
            lblDesc4 = new Label();
            cell5 = new Panel();
            btnBai5 = new Button();
            lblDesc5 = new Label();
            cell6 = new Panel();
            btnBai6 = new Button();
            lblDesc6 = new Label();
            cell7 = new Panel();
            btnBai7 = new Button();
            lblDesc7 = new Label();
            lblFooter = new Label();
            tplRoot.SuspendLayout();
            tplGrid.SuspendLayout();
            // 
            // tplRoot
            // 
            tplRoot.ColumnCount = 1;
            tplRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplRoot.Controls.Add(lblTitle, 0, 0);
            tplRoot.Controls.Add(lblSubtitle, 0, 1);
            tplRoot.Controls.Add(tplGrid, 0, 2);
            tplRoot.Controls.Add(lblFooter, 0, 3);
            tplRoot.Dock = DockStyle.Fill;
            tplRoot.Location = new Point(0, 0);
            tplRoot.Margin = new Padding(0);
            tplRoot.Name = "tplRoot";
            tplRoot.Padding = new Padding(32, 28, 32, 20);
            tplRoot.RowCount = 4;
            tplRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tplRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tplRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tplRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tplRoot.Size = new Size(680, 560);
            tplRoot.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(32, 28);
            lblTitle.Margin = new Padding(0, 0, 0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(616, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NT106 - Lập trình trên .NET";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Dock = DockStyle.Fill;
            lblSubtitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitle.Location = new Point(32, 70);
            lblSubtitle.Margin = new Padding(0, 0, 0, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(616, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Lab 02 · Chọn một bài để bắt đầu";
            lblSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tplGrid
            // 
            tplGrid.ColumnCount = 2;
            tplGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tplGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tplGrid.Controls.Add(cell1, 0, 0);
            tplGrid.Controls.Add(cell2, 1, 0);
            tplGrid.Controls.Add(cell3, 0, 1);
            tplGrid.Controls.Add(cell4, 1, 1);
            tplGrid.Controls.Add(cell5, 0, 2);
            tplGrid.Controls.Add(cell6, 1, 2);
            tplGrid.Controls.Add(cell7, 0, 3);
            tplGrid.Dock = DockStyle.Fill;
            tplGrid.Location = new Point(32, 100);
            tplGrid.Margin = new Padding(0);
            tplGrid.Name = "tplGrid";
            tplGrid.RowCount = 4;
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tplGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tplGrid.Size = new Size(616, 410);
            tplGrid.TabIndex = 2;
            // 
            // cell1
            // 
            cell1.Controls.Add(lblDesc1);
            cell1.Controls.Add(btnBai1);
            cell1.Dock = DockStyle.Fill;
            cell1.Location = new Point(0, 0);
            cell1.Margin = new Padding(0, 0, 10, 10);
            cell1.Name = "cell1";
            cell1.Size = new Size(298, 92);
            cell1.TabIndex = 0;
            // 
            // btnBai1
            // 
            btnBai1.BackColor = Color.FromArgb(37, 99, 235);
            btnBai1.Dock = DockStyle.Top;
            btnBai1.FlatAppearance.BorderSize = 0;
            btnBai1.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 60, 180);
            btnBai1.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnBai1.FlatStyle = FlatStyle.Flat;
            btnBai1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai1.ForeColor = Color.White;
            btnBai1.Location = new Point(0, 0);
            btnBai1.Margin = new Padding(0);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(298, 64);
            btnBai1.TabIndex = 0;
            btnBai1.Text = "Bài 1";
            btnBai1.UseVisualStyleBackColor = false;
            btnBai1.Click += btnBai1_Click;
            // 
            // lblDesc1
            // 
            lblDesc1.AutoSize = false;
            lblDesc1.Dock = DockStyle.Top;
            lblDesc1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc1.ForeColor = Color.FromArgb(100, 116, 139);
            lblDesc1.Location = new Point(0, 68);
            lblDesc1.Margin = new Padding(2, 4, 0, 0);
            lblDesc1.Name = "lblDesc1";
            lblDesc1.Padding = new Padding(2, 0, 0, 0);
            lblDesc1.Size = new Size(298, 18);
            lblDesc1.TabIndex = 1;
            lblDesc1.Text = "Ghi và đọc file văn bản";
            lblDesc1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell2
            // 
            cell2.Controls.Add(lblDesc2);
            cell2.Controls.Add(btnBai2);
            cell2.Dock = DockStyle.Fill;
            cell2.Location = new Point(308, 0);
            cell2.Margin = new Padding(10, 0, 0, 10);
            cell2.Name = "cell2";
            cell2.Size = new Size(298, 92);
            cell2.TabIndex = 1;
            // 
            // btnBai2
            // 
            btnBai2.BackColor = Color.FromArgb(241, 245, 249);
            btnBai2.Dock = DockStyle.Top;
            btnBai2.Enabled = false;
            btnBai2.FlatAppearance.BorderSize = 0;
            btnBai2.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai2.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai2.FlatStyle = FlatStyle.Flat;
            btnBai2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai2.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai2.Location = new Point(0, 0);
            btnBai2.Margin = new Padding(0);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(298, 64);
            btnBai2.TabIndex = 0;
            btnBai2.Text = "Bài 2";
            btnBai2.UseVisualStyleBackColor = false;
            // 
            // lblDesc2
            // 
            lblDesc2.AutoSize = false;
            lblDesc2.Dock = DockStyle.Top;
            lblDesc2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc2.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc2.Location = new Point(0, 68);
            lblDesc2.Margin = new Padding(2, 4, 0, 0);
            lblDesc2.Name = "lblDesc2";
            lblDesc2.Padding = new Padding(2, 0, 0, 0);
            lblDesc2.Size = new Size(298, 18);
            lblDesc2.TabIndex = 1;
            lblDesc2.Text = "Chưa triển khai";
            lblDesc2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell3
            // 
            cell3.Controls.Add(lblDesc3);
            cell3.Controls.Add(btnBai3);
            cell3.Dock = DockStyle.Fill;
            cell3.Location = new Point(0, 102);
            cell3.Margin = new Padding(0, 0, 10, 10);
            cell3.Name = "cell3";
            cell3.Size = new Size(298, 92);
            cell3.TabIndex = 2;
            // 
            // btnBai3
            // 
            btnBai3.BackColor = Color.FromArgb(241, 245, 249);
            btnBai3.Dock = DockStyle.Top;
            btnBai3.Enabled = false;
            btnBai3.FlatAppearance.BorderSize = 0;
            btnBai3.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai3.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai3.FlatStyle = FlatStyle.Flat;
            btnBai3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai3.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai3.Location = new Point(0, 0);
            btnBai3.Margin = new Padding(0);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(298, 64);
            btnBai3.TabIndex = 0;
            btnBai3.Text = "Bài 3";
            btnBai3.UseVisualStyleBackColor = false;
            // 
            // lblDesc3
            // 
            lblDesc3.AutoSize = false;
            lblDesc3.Dock = DockStyle.Top;
            lblDesc3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc3.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc3.Location = new Point(0, 68);
            lblDesc3.Margin = new Padding(2, 4, 0, 0);
            lblDesc3.Name = "lblDesc3";
            lblDesc3.Padding = new Padding(2, 0, 0, 0);
            lblDesc3.Size = new Size(298, 18);
            lblDesc3.TabIndex = 1;
            lblDesc3.Text = "Chưa triển khai";
            lblDesc3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell4
            // 
            cell4.Controls.Add(lblDesc4);
            cell4.Controls.Add(btnBai4);
            cell4.Dock = DockStyle.Fill;
            cell4.Location = new Point(308, 102);
            cell4.Margin = new Padding(10, 0, 0, 10);
            cell4.Name = "cell4";
            cell4.Size = new Size(298, 92);
            cell4.TabIndex = 3;
            // 
            // btnBai4
            // 
            btnBai4.BackColor = Color.FromArgb(241, 245, 249);
            btnBai4.Dock = DockStyle.Top;
            btnBai4.Enabled = false;
            btnBai4.FlatAppearance.BorderSize = 0;
            btnBai4.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai4.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai4.FlatStyle = FlatStyle.Flat;
            btnBai4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai4.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai4.Location = new Point(0, 0);
            btnBai4.Margin = new Padding(0);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(298, 64);
            btnBai4.TabIndex = 0;
            btnBai4.Text = "Bài 4";
            btnBai4.UseVisualStyleBackColor = false;
            // 
            // lblDesc4
            // 
            lblDesc4.AutoSize = false;
            lblDesc4.Dock = DockStyle.Top;
            lblDesc4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc4.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc4.Location = new Point(0, 68);
            lblDesc4.Margin = new Padding(2, 4, 0, 0);
            lblDesc4.Name = "lblDesc4";
            lblDesc4.Padding = new Padding(2, 0, 0, 0);
            lblDesc4.Size = new Size(298, 18);
            lblDesc4.TabIndex = 1;
            lblDesc4.Text = "Chưa triển khai";
            lblDesc4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell5
            // 
            cell5.Controls.Add(lblDesc5);
            cell5.Controls.Add(btnBai5);
            cell5.Dock = DockStyle.Fill;
            cell5.Location = new Point(0, 204);
            cell5.Margin = new Padding(0, 0, 10, 10);
            cell5.Name = "cell5";
            cell5.Size = new Size(298, 92);
            cell5.TabIndex = 4;
            // 
            // btnBai5
            // 
            btnBai5.BackColor = Color.FromArgb(241, 245, 249);
            btnBai5.Dock = DockStyle.Top;
            btnBai5.Enabled = false;
            btnBai5.FlatAppearance.BorderSize = 0;
            btnBai5.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai5.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai5.FlatStyle = FlatStyle.Flat;
            btnBai5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai5.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai5.Location = new Point(0, 0);
            btnBai5.Margin = new Padding(0);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(298, 64);
            btnBai5.TabIndex = 0;
            btnBai5.Text = "Bài 5";
            btnBai5.UseVisualStyleBackColor = false;
            // 
            // lblDesc5
            // 
            lblDesc5.AutoSize = false;
            lblDesc5.Dock = DockStyle.Top;
            lblDesc5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc5.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc5.Location = new Point(0, 68);
            lblDesc5.Margin = new Padding(2, 4, 0, 0);
            lblDesc5.Name = "lblDesc5";
            lblDesc5.Padding = new Padding(2, 0, 0, 0);
            lblDesc5.Size = new Size(298, 18);
            lblDesc5.TabIndex = 1;
            lblDesc5.Text = "Chưa triển khai";
            lblDesc5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell6
            // 
            cell6.Controls.Add(lblDesc6);
            cell6.Controls.Add(btnBai6);
            cell6.Dock = DockStyle.Fill;
            cell6.Location = new Point(308, 204);
            cell6.Margin = new Padding(10, 0, 0, 10);
            cell6.Name = "cell6";
            cell6.Size = new Size(298, 92);
            cell6.TabIndex = 5;
            // 
            // btnBai6
            // 
            btnBai6.BackColor = Color.FromArgb(241, 245, 249);
            btnBai6.Dock = DockStyle.Top;
            btnBai6.Enabled = false;
            btnBai6.FlatAppearance.BorderSize = 0;
            btnBai6.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai6.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai6.FlatStyle = FlatStyle.Flat;
            btnBai6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai6.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai6.Location = new Point(0, 0);
            btnBai6.Margin = new Padding(0);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(298, 64);
            btnBai6.TabIndex = 0;
            btnBai6.Text = "Bài 6";
            btnBai6.UseVisualStyleBackColor = false;
            // 
            // lblDesc6
            // 
            lblDesc6.AutoSize = false;
            lblDesc6.Dock = DockStyle.Top;
            lblDesc6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc6.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc6.Location = new Point(0, 68);
            lblDesc6.Margin = new Padding(2, 4, 0, 0);
            lblDesc6.Name = "lblDesc6";
            lblDesc6.Padding = new Padding(2, 0, 0, 0);
            lblDesc6.Size = new Size(298, 18);
            lblDesc6.TabIndex = 1;
            lblDesc6.Text = "Chưa triển khai";
            lblDesc6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cell7
            // 
            cell7.Controls.Add(lblDesc7);
            cell7.Controls.Add(btnBai7);
            cell7.Dock = DockStyle.Fill;
            cell7.Location = new Point(0, 306);
            cell7.Margin = new Padding(0, 0, 10, 10);
            cell7.Name = "cell7";
            cell7.Size = new Size(298, 92);
            cell7.TabIndex = 6;
            // 
            // btnBai7
            // 
            btnBai7.BackColor = Color.FromArgb(241, 245, 249);
            btnBai7.Dock = DockStyle.Top;
            btnBai7.Enabled = false;
            btnBai7.FlatAppearance.BorderSize = 0;
            btnBai7.FlatAppearance.MouseDownBackColor = Color.FromArgb(241, 245, 249);
            btnBai7.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnBai7.FlatStyle = FlatStyle.Flat;
            btnBai7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBai7.ForeColor = Color.FromArgb(148, 163, 184);
            btnBai7.Location = new Point(0, 0);
            btnBai7.Margin = new Padding(0);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(298, 64);
            btnBai7.TabIndex = 0;
            btnBai7.Text = "Bài 7";
            btnBai7.UseVisualStyleBackColor = false;
            // 
            // lblDesc7
            // 
            lblDesc7.AutoSize = false;
            lblDesc7.Dock = DockStyle.Top;
            lblDesc7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc7.ForeColor = Color.FromArgb(148, 163, 184);
            lblDesc7.Location = new Point(0, 68);
            lblDesc7.Margin = new Padding(2, 4, 0, 0);
            lblDesc7.Name = "lblDesc7";
            lblDesc7.Padding = new Padding(2, 0, 0, 0);
            lblDesc7.Size = new Size(298, 18);
            lblDesc7.TabIndex = 1;
            lblDesc7.Text = "Chưa triển khai";
            lblDesc7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Dock = DockStyle.Fill;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(32, 510);
            lblFooter.Margin = new Padding(0, 0, 0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(616, 30);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "SV: 25521506 · Bài 1 đã hoàn thành, các bài còn lại sẽ bổ sung sau";
            lblFooter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(680, 560);
            Controls.Add(tplRoot);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02 Menu";
            tplRoot.ResumeLayout(false);
            tplRoot.PerformLayout();
            tplGrid.ResumeLayout(false);
            tplGrid.PerformLayout();
        }

        #endregion

        private TableLayoutPanel tplRoot;
        private Label lblTitle;
        private Label lblSubtitle;
        private TableLayoutPanel tplGrid;
        private Panel cell1;
        private Button btnBai1;
        private Label lblDesc1;
        private Panel cell2;
        private Button btnBai2;
        private Label lblDesc2;
        private Panel cell3;
        private Button btnBai3;
        private Label lblDesc3;
        private Panel cell4;
        private Button btnBai4;
        private Label lblDesc4;
        private Panel cell5;
        private Button btnBai5;
        private Label lblDesc5;
        private Panel cell6;
        private Button btnBai6;
        private Label lblDesc6;
        private Panel cell7;
        private Button btnBai7;
        private Label lblDesc7;
        private Label lblFooter;
    }
}