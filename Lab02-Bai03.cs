using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NT106.R14._1_Lab02_25521506
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input3.txt"))
            {
                MessageBox.Show("Chưa tạo file input3.txt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FileStream fs = new FileStream("input3.txt", FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                rtbThongTin.Text = sr.ReadToEnd();
            }

            lblTrangThai.Text = "Đã đọc input3.txt";
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input3.txt"))
            {
                MessageBox.Show("Chưa tìm thấy file input3.txt để tính toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<string> results = new List<string>();

                using (FileStream fsIn = new FileStream("input3.txt", FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fsIn))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string trimmed = line.Trim();
                        if (string.IsNullOrEmpty(trimmed))
                        {
                            continue;
                        }

                        try
                        {
                            double value = TinhBieuThuc(trimmed);
                            string formattedVal = value.ToString("G", CultureInfo.InvariantCulture);
                            results.Add($"{trimmed} = {formattedVal}");
                        }
                        catch (Exception ex)
                        {
                            results.Add($"{trimmed} = Lỗi ({ex.Message})");
                        }
                    }
                }

                using (FileStream fsOut = new FileStream("output3.txt", FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fsOut))
                {
                    foreach (string res in results)
                    {
                        sw.WriteLine(res);
                    }
                }

                using (FileStream fsRead = new FileStream("output3.txt", FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fsRead))
                {
                    rtbThongTin.Text = sr.ReadToEnd();
                }

                lblTrangThai.Text = "Đã tính và ghi vào output3.txt";
                MessageBox.Show("Đã ghi kết quả tính toán xuống output3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xử lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static double TinhBieuThuc(string bieuThuc)
        {
            string s = bieuThuc.Replace("–", "-").Replace("—", "-");
            List<string> tokens = TachToken(s);
            List<string> rpn = ChuyenSangHauTo(tokens);
            return TinhHauTo(rpn);
        }

        private static List<string> TachToken(string s)
        {
            List<string> tokens = new List<string>();
            int i = 0;

            while (i < s.Length)
            {
                char c = s[i];

                if (char.IsWhiteSpace(c))
                {
                    i++;
                    continue;
                }

                if (c == '+' || c == '*' || c == '/' || c == '(' || c == ')')
                {
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }

                if (c == '-')
                {
                    bool isUnary = (tokens.Count == 0 ||
                                    tokens[^1] == "(" ||
                                    tokens[^1] == "+" ||
                                    tokens[^1] == "-" ||
                                    tokens[^1] == "*" ||
                                    tokens[^1] == "/");

                    if (isUnary)
                    {
                        int start = i;
                        i++;
                        while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '.'))
                        {
                            i++;
                        }
                        if (i > start + 1)
                        {
                            tokens.Add(s.Substring(start, i - start));
                            continue;
                        }
                    }

                    tokens.Add("-");
                    i++;
                    continue;
                }

                if (char.IsDigit(c) || c == '.')
                {
                    int start = i;
                    while (i < s.Length && (char.IsDigit(s[i]) || s[i] == '.'))
                    {
                        i++;
                    }
                    tokens.Add(s.Substring(start, i - start));
                    continue;
                }

                throw new Exception($"Ký tự không hợp lệ: {c}");
            }

            return tokens;
        }

        private static int DoUuTien(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        private static List<string> ChuyenSangHauTo(List<string> tokens)
        {
            List<string> output = new List<string>();
            Stack<string> stack = new Stack<string>();

            foreach (string token in tokens)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        output.Add(stack.Pop());
                    }

                    if (stack.Count == 0)
                    {
                        throw new Exception("Lỗi dấu ngoặc đơn không hợp lệ");
                    }
                    stack.Pop(); // Bo dau '('
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    while (stack.Count > 0 && DoUuTien(stack.Peek()) >= DoUuTien(token))
                    {
                        output.Add(stack.Pop());
                    }
                    stack.Push(token);
                }
            }

            while (stack.Count > 0)
            {
                string top = stack.Pop();
                if (top == "(" || top == ")")
                {
                    throw new Exception("Lỗi dấu ngoặc đơn không hợp lệ");
                }
                output.Add(top);
            }

            return output;
        }

        private static double TinhHauTo(List<string> rpn)
        {
            Stack<double> stack = new Stack<double>();

            foreach (string token in rpn)
            {
                if (double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                {
                    stack.Push(val);
                }
                else if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("Biểu thức không hợp lệ");
                    }

                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            if (b == 0)
                            {
                                throw new Exception("Không thể chia cho 0");
                            }
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            if (stack.Count != 1)
            {
                throw new Exception("Biểu thức không hợp lệ");
            }

            return stack.Pop();
        }
    }
}
