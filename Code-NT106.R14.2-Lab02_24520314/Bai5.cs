using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_NT106.R14._2_Lab02_24520314 // Kiểm tra lại đúng tên Namespace dự án của bạn
{
    public struct Film
    {
        public string Name;
        public double standardPrice;
        public List<int> rooms;
        public List<List<List<string>>> seats;
        public int numOfTickets;
        public int numOfSoldTickets;
        public int numOfTicketsLeft;
        public double revenue;

        public Film(string _Name, string _Price, string _rooms, string _numOfTickets)
        {
            Name = _Name;
            standardPrice = double.Parse(_Price);
            rooms = new List<int>();
            string room = "";
            foreach (char r in _rooms)
            {
                if (r == ' ')
                {
                    rooms.Add(int.Parse(room));
                    room = "";
                }
                else room += r;
            }
            rooms.Add(int.Parse(room));

            seats = new List<List<List<string>>>();
            for (int i1 = 0; i1 < rooms.Count; i1++)
            {
                seats.Add(new List<List<string>>());
                seats[i1].Add(new List<string> { "A1", "A5", "C1", "C5" });
                seats[i1].Add(new List<string> { "A2", "A3", "A4", "C2", "C3", "C4" });
                seats[i1].Add(new List<string> { "B2", "B3", "B4" });
            }

            numOfTickets = int.Parse(_numOfTickets);
            numOfSoldTickets = 0;
            numOfTicketsLeft = numOfTickets;
            revenue = 0;
        }
    }

    public partial class Bai5 : Form
    {
        List<Film> filmList = new List<Film>();

        public Bai5()
        {
            InitializeComponent();
            cboTicketClass.Items.AddRange(new string[] { "Vé vớt", "Vé chuẩn", "Vé VIP" });
        }

        private void clearInfo()
        {
            txtCustomName.Text = String.Empty;
            cboFilmName.Text = String.Empty;
            cboRooms.Text = String.Empty;
            cboRooms.Items.Clear();
            cboTicketClass.Text = String.Empty;
            cboSeat.Text = String.Empty;
            cboSeat.Items.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            filmList.Clear();
            clearInfo();
            rtbCustomInfo.Text = String.Empty;

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        while (!sr.EndOfStream)
                        {
                            Film f = new Film(sr.ReadLine(), sr.ReadLine(),
                                sr.ReadLine(), sr.ReadLine());
                            filmList.Add(f);
                        }
                    }

                    MessageBox.Show("Đọc file thành công!");

                    for (int i = 0; i < filmList.Count; i++)
                    {
                        cboFilmName.Items.Add(filmList[i].Name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc file: {ex.Message}");
                    return;
                }
            }
        }

        private void cboFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboFilmName.SelectedIndex;
            if (index == -1) return;

            cboRooms.Items.Clear();
            foreach (int r in filmList[index].rooms)
            {
                cboRooms.Items.Add(r);
            }
            cboSeat.Items.Clear();
        }

        // ĐÂY LÀ HÀM BỊ THIẾU TRONG CODE 1 CỦA BẠN (DÙNG ĐỂ NẠP GHẾ)
        private void cboTicketClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilmName.SelectedIndex == -1) return;
            if (cboRooms.SelectedIndex == -1) return;
            if (cboTicketClass.SelectedIndex == -1) return;

            cboSeat.Items.Clear();
            int filmIndex = cboFilmName.SelectedIndex;
            int roomIndex = cboRooms.SelectedIndex;
            int classIndex = cboTicketClass.SelectedIndex;

            foreach (string s in filmList[filmIndex].seats[roomIndex][classIndex])
            {
                cboSeat.Items.Add(s);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtCustomName.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }

            if (cboFilmName.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phim");
                return;
            }

            if (cboRooms.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu");
                return;
            }

            if (cboTicketClass.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hạn mức vé");
                return;
            }

            if (cboSeat.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chỗ ngồi");
                return;
            }

            int filmIndex = cboFilmName.SelectedIndex;
            int classIndex = cboTicketClass.SelectedIndex;
            int roomIndex = cboRooms.SelectedIndex;
            string selectedSeat = cboSeat.SelectedItem.ToString();
            double price = filmList[filmIndex].standardPrice;
            if (classIndex == 0) price /= 4;
            else
            {
                if (classIndex == 2) price *= 2;
            }

            rtbCustomInfo.Text +=
                $"Tên khách hàng: {txtCustomName.Text}{Environment.NewLine}" +
                $"Tên phim: {cboFilmName.SelectedItem}{Environment.NewLine}" +
                $"Loại vé: {cboTicketClass.SelectedItem}{Environment.NewLine}" +
                $"Phòng chiếu: {cboRooms.SelectedItem}{Environment.NewLine}" +
                $"Vị trí ghế: {selectedSeat}{Environment.NewLine}" +
                $"Cái giá phải trả: {price}{Environment.NewLine}" +
                $"{Environment.NewLine}";

            var temp = filmList[filmIndex];
            temp.numOfSoldTickets++;
            temp.numOfTicketsLeft--;
            temp.revenue += price;
            filmList[filmIndex] = temp;
            filmList[filmIndex].seats[cboRooms.SelectedIndex][classIndex].RemoveAt(cboSeat.SelectedIndex);

            clearInfo();
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var filmIndexList = new (double, int)[filmList.Count];

                for (int i = 0; i < filmList.Count; i++)
                {
                    filmIndexList[i].Item1 = filmList[i].revenue;
                    filmIndexList[i].Item2 = i;
                }

                Array.Sort(filmIndexList);

                try
                {
                    using (StreamWriter sw = new StreamWriter(ofd.FileName))
                    {
                        pb_progress.Minimum = 0;
                        pb_progress.Maximum = filmIndexList.Length;
                        pb_progress.Value = 0;

                        for (int i = filmIndexList.Length - 1; i >= 0; i--)
                        {
                            int index = filmIndexList[i].Item2;
                            sw.WriteLine($"Tên phim: {filmList[index].Name}");
                            sw.WriteLine($"Số vé bán ra: {filmList[index].numOfSoldTickets}");
                            sw.WriteLine($"Số vé tồn: {filmList[index].numOfTicketsLeft}");
                            sw.WriteLine($"Tỉ lệ vé bán ra: {1.0 * filmList[index].numOfSoldTickets / filmList[index].numOfTickets}");
                            sw.WriteLine($"Doanh thu: {filmList[index].revenue}");
                            sw.WriteLine($"Thứ hạng: {filmIndexList.Length - i}{Environment.NewLine}");

                            pb_progress.Value++;
                            await Task.Delay(5);
                        }

                        MessageBox.Show("Ghi file thành công!");
                        pb_progress.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi ghi file: {ex.Message}");
                    return;
                }
            }
        }
    }
}