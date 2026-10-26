using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_NT106.R14._2_Lab02_24520314
{
    public class ExpressionParser
    {
        private readonly string input;
        private int pos;

        public ExpressionParser(string expression)
        {
            input = expression;
            pos = 0;
        }

        // Hàm chính để tính biểu thức
        public double Parse()
        {
            double result = ParseExpression();

            SkipSpaces();

            if (pos < input.Length)
                throw new Exception("Biểu thức không hợp lệ.");

            return result;
        }

        // Cộng và trừ
        private double ParseExpression()
        {
            double result = ParseTerm();

            while (true)
            {
                SkipSpaces();

                if (Match('+'))
                    result += ParseTerm();
                else if (Match('-'))
                    result -= ParseTerm();
                else
                    break;
            }

            return result;
        }

        // Nhân và chia
        private double ParseTerm()
        {
            double result = ParseFactor();

            while (true)
            {
                SkipSpaces();

                if (Match('*'))
                {
                    result *= ParseFactor();
                }
                else if (Match('/'))
                {
                    double divisor = ParseFactor();

                    if (divisor == 0)
                        throw new DivideByZeroException(
                            "Không thể chia cho 0."
                        );

                    result /= divisor;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        // Số, dấu âm/dương và ngoặc đơn
        private double ParseFactor()
        {
            SkipSpaces();

            if (Match('+'))
                return ParseFactor();

            if (Match('-'))
                return -ParseFactor();

            if (Match('('))
            {
                double result = ParseExpression();

                SkipSpaces();

                if (!Match(')'))
                    throw new Exception("Thiếu dấu đóng ngoặc.");

                return result;
            }

            return ParseNumber();
        }

        // Đọc số nguyên hoặc số thập phân
        private double ParseNumber()
        {
            SkipSpaces();

            int start = pos;
            bool hasDigit = false;

            while (pos < input.Length &&
                   char.IsDigit(input[pos]))
            {
                pos++;
                hasDigit = true;
            }

            if (pos < input.Length && input[pos] == '.')
            {
                pos++;

                while (pos < input.Length &&
                       char.IsDigit(input[pos]))
                {
                    pos++;
                    hasDigit = true;
                }
            }

            if (!hasDigit)
                throw new Exception("Thiếu số trong biểu thức.");

            string number = input.Substring(start, pos - start);

            return double.Parse(
                number,
                CultureInfo.InvariantCulture
            );
        }

        private void SkipSpaces()
        {
            while (pos < input.Length &&
                   char.IsWhiteSpace(input[pos]))
            {
                pos++;
            }
        }

        private bool Match(char c)
        {
            if (pos < input.Length && input[pos] == c)
            {
                pos++;
                return true;
            }

            return false;
        }
    }
}
