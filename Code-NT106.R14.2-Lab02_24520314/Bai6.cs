using Microsoft.Data.Sqlite;
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
    public partial class Bai6 : Form
    {
        string connectToDBString = @"Data Source=C:\Users\Administrator\Desktop\LTMCB\Tài liệu thực hành\Lab2\Code-NT106.R14.2-Lab02_24520314\Database\Bai2\.FOOD.db;";

        public Bai6()
        {
            InitializeComponent();
        }

        private readonly string foodImageFolder = Path.GetFullPath(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\Image\Food"));

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFoodImageAdded.Text = ofd.FileName;
            }

        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                string sql = "SELECT FOODNAME FROM FOOD";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lvFoodList.Items.Add(reader["FOODNAME"].ToString());
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtContributorNameAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên của bạn!");
                return;
            }

            if (txtFoodImageAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            if (txtFoodImageAdded.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng thêm ảnh!");
                return;
            }

            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                string sql = "INSERT INTO FOOD (CONTRIBUTORNAME, FOODNAME, FOODIMAGEPATH) VALUES (@contributorName, @foodName, @foodImagePath)";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@contributorName", $"{txtContributorNameAdded.Text}");
                    cmd.Parameters.AddWithValue("@foodName", $"{txtFoodNameAdded.Text}");
                    cmd.Parameters.AddWithValue("@foodImagePath", $"{txtFoodImageAdded.Text}");
                    cmd.ExecuteNonQuery();
                }
            }

            //rtb_foodsList.Text += txtFoodNameAdded.Text + Environment.NewLine;

            MessageBox.Show("Thêm thành công!");
        }

        private void btnFindFoods_Click(object sender, EventArgs e)
        {
            using (var conn = new SqliteConnection(connectToDBString))
            {
                conn.Open();

                int numOfFoods = 0;

                string sql = "SELECT COUNT (*) FROM FOOD";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    numOfFoods = Int32.Parse(cmd.ExecuteScalar().ToString());
                    numOfFoods++;
                }

                Random ran = new Random();
                int randomFood = ran.Next(numOfFoods);

                sql = "SELECT CONTRIBUTORNAME, FOODNAME, FOODIMAGEPATH FROM FOOD WHERE ID = @id";
                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", randomFood);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtContributorNameFound.Text = reader["CONTRIBUTORNAME"].ToString();
                            txtFoodNameFound.Text = reader["FOODNAME"].ToString();
                            string tenFile = Path.GetFileName(
                                reader["FOODIMAGEPATH"].ToString());

                            string duongDanAnh = Path.Combine(foodImageFolder, tenFile);

                            if (File.Exists(duongDanAnh))
                            {
                                using (Image img = Image.FromFile(duongDanAnh))
                                {
                                    picFoodImageFound.Image = new Bitmap(img);
                                }

                                picFoodImageFound.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy ảnh: " + duongDanAnh);
                            }
                        }
                    }
                }
            }
        }
    }
}
