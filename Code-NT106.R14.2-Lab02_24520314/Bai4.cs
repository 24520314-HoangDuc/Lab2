using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Code_NT106.R14._2_Lab02_24520314
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private List<SinhVien> danhSach = new List<SinhVien>();
        private int viTriHienTai = 0;

        private void HienThiDanhSach()
        {
            StringBuilder sb = new StringBuilder();

            foreach (SinhVien sv in danhSach)
            {
                sb.AppendLine(sv.HoTen);
                sb.AppendLine(sv.MSSV.ToString());
                sb.AppendLine(sv.DienThoai);
                sb.AppendLine(sv.Diem1.ToString());
                sb.AppendLine(sv.Diem2.ToString());
                sb.AppendLine(sv.Diem3.ToString());
                sb.AppendLine(sv.DiemTB.ToString());
                sb.AppendLine();
            }

            rtbDanhSach.Text = sb.ToString();
        }


        private void HienThiSinhVien()
        {
            if (danhSach.Count == 0)
            {
                txtTenHienThi.Clear();
                txtMSSVHienThi.Clear();
                txtDienThoaiHienThi.Clear();
                txtDiem1HienThi.Clear();
                txtDiem2HienThi.Clear();
                txtDiem3HienThi.Clear();
                txtDiemTBHienThi.Clear();
                lblTrang.Text = "0 / 0";
                return;
            }

            SinhVien sv = danhSach[viTriHienTai];

            txtTenHienThi.Text = sv.HoTen;
            txtMSSVHienThi.Text = sv.MSSV.ToString();
            txtDienThoaiHienThi.Text = sv.DienThoai;
            txtDiem1HienThi.Text = sv.Diem1.ToString();
            txtDiem2HienThi.Text = sv.Diem2.ToString();
            txtDiem3HienThi.Text = sv.Diem3.ToString();
            txtDiemTBHienThi.Text = sv.DiemTB.ToString("0.00");

            // Số trang bắt đầu từ 1
            lblTrang.Text =
                (viTriHienTai + 1) + " / " + danhSach.Count;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();
            string mssvText = txtMSSV.Text.Trim();

            // Kiểm tra họ tên
            if (hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                txtHoten.Focus();
                return;
            }

            // MSSV phải gồm đúng 8 chữ số
            if (!Regex.IsMatch(mssvText, @"^\d{8}$"))
            {
                MessageBox.Show("MSSV phải gồm đúng 8 chữ số.");
                txtMSSV.Focus();
                return;
            }

            // Số điện thoại phải gồm 10 chữ số, bắt đầu bằng 0
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show(
                    "Số điện thoại phải có 10 chữ số và bắt đầu bằng 0.");
                txtDienThoai.Focus();
                return;
            }

            // Kiểm tra điểm
            if (!float.TryParse(txtDiem1.Text, out float d1) ||
                !float.TryParse(txtDiem2.Text, out float d2) ||
                !float.TryParse(txtDiem3.Text, out float d3))
            {
                MessageBox.Show("Điểm phải là số hợp lệ.");
                return;
            }

            if (d1 < 0 || d1 > 10 ||
                d2 < 0 || d2 > 10 ||
                d3 < 0 || d3 > 10)
            {
                MessageBox.Show("Điểm mỗi môn phải từ 0 đến 10.");
                return;
            }

            int mssv = int.Parse(mssvText);

            // Không cho trùng MSSV
            if (danhSach.Any(sv => sv.MSSV == mssv))
            {
                MessageBox.Show("MSSV đã tồn tại.");
                return;
            }

            SinhVien sv = new SinhVien(
                hoTen, mssv, sdt, d1, d2, d3);
            // Tính điểm trung bình ngay khi thêm
            sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3.0f;

            // Thêm sinh viên vào danh sách
            danhSach.Add(sv);

            // Hiển thị điểm trung bình ở ô bên trái
            txtDiemTB.Text = sv.DiemTB.ToString("0.00");

            // Hiển thị danh sách ở khung giữa
            HienThiDanhSach();

            MessageBox.Show("Thêm sinh viên thành công!");

            txtHoten.Focus();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên để ghi file.");
                return;
            }

            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "input4.txt");

                #pragma warning disable SYSLIB0011
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(
                    path, FileMode.Create, FileAccess.Write))
                {
                    SinhVien[] mangSinhVien = danhSach.ToArray();
                    formatter.Serialize(fs, mangSinhVien);
                }
                #pragma warning restore SYSLIB0011

                MessageBox.Show("Đã ghi mảng sinh viên vào input4.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "input4.txt");

            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy input4.txt. Hãy ghi file trước.");
                return;
            }

            try
            {
#pragma warning disable SYSLIB0011
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(
                    path, FileMode.Open, FileAccess.Read))
                {
                    danhSach = new List<SinhVien>(
                        (SinhVien[])formatter.Deserialize(fs));
                }
#pragma warning restore SYSLIB0011

                // Tính điểm trung bình
                foreach (SinhVien sv in danhSach)
                {
                    sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3.0f;
                }

                // Ghi kết quả ra file văn bản
                string outputPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "output4.txt");

                using (StreamWriter sw = new StreamWriter(
                    outputPath, false, Encoding.UTF8))
                {
                    foreach (SinhVien sv in danhSach)
                    {
                        sw.WriteLine("Ho ten: " + sv.HoTen);
                        sw.WriteLine("MSSV: " + sv.MSSV);
                        sw.WriteLine("Dien thoai: " + sv.DienThoai);
                        sw.WriteLine("Diem mon 1: " + sv.Diem1);
                        sw.WriteLine("Diem mon 2: " + sv.Diem2);
                        sw.WriteLine("Diem mon 3: " + sv.Diem3);
                        sw.WriteLine("Diem trung binh: " +
                            sv.DiemTB.ToString("0.00"));
                        sw.WriteLine("---------------------------");
                    }
                }

                // Hiển thị danh sách và sinh viên đầu tiên
                HienThiDanhSach();
                viTriHienTai = 0;
                HienThiSinhVien();

                MessageBox.Show(
                    "Đã đọc file, tính điểm trung bình và ghi output4.txt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc hoặc xử lý file: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
                return;

            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                HienThiSinhVien();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (danhSach.Count == 0)
                return;

            if (viTriHienTai < danhSach.Count - 1)
            {
                viTriHienTai++;
                HienThiSinhVien();
            }
        }
    }
}
