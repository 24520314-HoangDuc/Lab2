using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.R14._2_Lab02_24520314
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            rtbNoiDung.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc toàn bộ nội dung file input1.txt
                using (StreamReader sr = new StreamReader("input1.txt"))
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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // Đọc toàn bộ nội dung file input1.txt
                using (StreamReader sr = new StreamReader("input1.txt"))
                {
                    string noiDung = sr.ReadToEnd();

                    // Chuyển toàn bộ ký tự sang chữ in hoa
                    string noiDungInHoa = noiDung.ToUpper();

                    // Ghi nội dung in hoa xuống output1.txt
                    using (StreamWriter sw = new StreamWriter("output1.txt"))
                    {
                        sw.Write(noiDungInHoa);
                    }
                }

                MessageBox.Show("Ghi file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
