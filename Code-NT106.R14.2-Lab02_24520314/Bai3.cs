using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.R14._2_Lab02_24520314
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc toàn bộ nội dung file input3.txt
                using (StreamReader sr = new StreamReader("input3.txt"))
                {
                    string noiDung = sr.ReadToEnd();

                    // Hiển thị nội dung lên RichTextBox
                    rtbNoiDung.Text = noiDung;
                }

                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string[] cacDong = File.ReadAllLines("input3.txt");

                using (StreamWriter sw = new StreamWriter("output3.txt"))
                {
                    foreach (string bieuThuc in cacDong)
                    {
                        if (string.IsNullOrWhiteSpace(bieuThuc))
                            continue;

                        try
                        {
                            ExpressionParser parser =
                                new ExpressionParser(bieuThuc);

                            double ketQua = parser.Parse();

                            sw.WriteLine(
                                $"{bieuThuc} = " +
                                ketQua.ToString(
                                    "G",
                                    CultureInfo.InvariantCulture
                                )
                            );
                        }
                        catch (Exception ex)
                        {
                            sw.WriteLine(
                                $"{bieuThuc} = Lỗi: {ex.Message}"
                            );
                        }
                    }
                }

                MessageBox.Show("Đã tính toán và ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc/ghi file: " + ex.Message);
            }
        }
    }
}
