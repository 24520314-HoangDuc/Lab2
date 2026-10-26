using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.R14._2_Lab02_24520314
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Chọn file cần đọc";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy tên file và đường dẫn
                    string name = ofd.SafeFileName;
                    string url = ofd.FileName;

                    // Lấy kích thước file (byte)
                    FileInfo fi = new FileInfo(url);
                    long kichThuoc = fi.Length;

                    // Đọc nội dung file
                    string noiDung;

                    using (StreamReader sr = new StreamReader(url))
                    {
                        noiDung = sr.ReadToEnd();
                    }

                    // Đếm số dòng
                    int soDong = noiDung.Length == 0
                        ? 0
                        : Regex.Split(noiDung, "\r\n|\r|\n").Length;

                    // Đếm số từ
                    int soTu = Regex.Matches(noiDung, @"\S+").Count;

                    // Đếm số ký tự
                    int soKyTu = noiDung.Length;

                    // Hiển thị thông tin
                    txtTenFile.Text = name;
                    txtKichThuoc.Text = kichThuoc + " byte";
                    txtURL.Text = url;
                    txtSoDong.Text = soDong.ToString();
                    txtSoTu.Text = soTu.ToString();
                    txtSoKyTu.Text = soKyTu.ToString();

                    // Hiển thị nội dung file
                    rtbNoiDung.Text = noiDung;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi đọc file: " + ex.Message,
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtTenFile.Clear();
            txtKichThuoc.Clear();
            txtURL.Clear();
            txtSoDong.Clear();
            txtSoTu.Clear();
            txtSoKyTu.Clear();
            rtbNoiDung.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
