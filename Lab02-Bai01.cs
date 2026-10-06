using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input1.txt"))
            {
                MessageBox.Show("Chưa tạo file input1.txt");
                return;
            }

            using (StreamReader sr = new StreamReader("input1.txt"))
            {
                rtbThongTin.Text = sr.ReadToEnd();
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("output1.txt"))
            {
                sw.Write(rtbThongTin.Text.ToUpper());
            }

            using (StreamReader sr = new StreamReader("output1.txt"))
            {
                rtbThongTin.Text = sr.ReadToEnd();
            }
            MessageBox.Show("Đã ghi xong");
        }
    }
}
