using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai01 : Form
    {
        private const string InputFile = "input1.txt";
        private const string OutputFile = "output1.txt";

        // true khi lblTrangThai đang hiển thị thông báo thao tác, false khi đang hiển thị bộ đếm ký tự.
        private bool _coThongBao;

        public Lab02_Bai01()
        {
            InitializeComponent();
            CapNhatTrangThai();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InputFile))
            {
                SetTrangThai($"Không tìm thấy {InputFile}", true);
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(InputFile))
                {
                    rtbThongTin.Text = sr.ReadToEnd();
                }

                SetTrangThai($"Đã đọc {InputFile}");
            }
            catch (IOException ex)
            {
                SetTrangThai("Lỗi khi đọc file: " + ex.Message, true);
            }
            catch (UnauthorizedAccessException ex)
            {
                SetTrangThai("Không có quyền đọc file: " + ex.Message, true);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(OutputFile))
                {
                    sw.Write(rtbThongTin.Text.ToUpper());
                }

                using (StreamReader sr = new StreamReader(OutputFile))
                {
                    rtbThongTin.Text = sr.ReadToEnd();
                }

                SetTrangThai($"Đã ghi xong {OutputFile}");
            }
            catch (IOException ex)
            {
                SetTrangThai("Lỗi khi ghi file: " + ex.Message, true);
            }
            catch (UnauthorizedAccessException ex)
            {
                SetTrangThai("Không có quyền ghi file: " + ex.Message, true);
            }
        }

        private void rtbThongTin_TextChanged(object sender, EventArgs e)
        {
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            // Chỉ cập nhật bộ đếm ký tự, giữ nguyên thông báo trạng thái nếu đang có.
            if (_coThongBao)
            {
                return;
            }

            int kyTu = rtbThongTin.TextLength;
            int dong = rtbThongTin.Lines.Length;
            lblTrangThai.Text = $"{kyTu} ký tự · {dong} dòng";
        }

        private void SetTrangThai(string noiDung, bool loi = false)
        {
            _coThongBao = true;
            lblTrangThai.ForeColor = loi
                ? Color.FromArgb(220, 38, 38)
                : Color.FromArgb(100, 116, 139);
            lblTrangThai.Text = noiDung;
        }
    }
}