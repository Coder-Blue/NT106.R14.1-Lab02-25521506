using System.Globalization;

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

            rtbThongTin.Text = File.ReadAllText("input3.txt");
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
                List<string> ketQua = File.ReadAllLines("input3.txt")
                    .Select(dong => dong.Trim())
                    .Where(dong => dong.Length > 0)
                    .Select(TinhDong)
                    .ToList();

                File.WriteAllLines("output3.txt", ketQua);
                rtbThongTin.Text = File.ReadAllText("output3.txt");

                lblTrangThai.Text = "Đã tính và ghi vào output3.txt";
                MessageBox.Show("Đã ghi kết quả tính toán xuống output3.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi trong quá trình xử lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string TinhDong(string dong)
        {
            try
            {
                double giaTri = TinhBieuThuc(dong);
                return $"{dong} = {giaTri.ToString("G", CultureInfo.InvariantCulture)}";
            }
            catch (Exception ex)
            {
                return $"{dong} = Lỗi ({ex.Message})";
            }
        }

        public static double TinhBieuThuc(string bieuThuc)
        {
            string s = bieuThuc.Replace("–", "-").Replace("—", "-");
            return TinhHauTo(ChuyenSangHauTo(TachToken(s)));
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
                    bool laSoAm = tokens.Count == 0
                        || tokens[^1] == "("
                        || tokens[^1] == "+"
                        || tokens[^1] == "-"
                        || tokens[^1] == "*"
                        || tokens[^1] == "/";

                    if (laSoAm)
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

        private static int DoUuTien(string op) =>
            op == "+" || op == "-" ? 1 : op == "*" || op == "/" ? 2 : 0;

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

                    stack.Pop();
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
