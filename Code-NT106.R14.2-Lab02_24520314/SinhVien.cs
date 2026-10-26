using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_NT106.R14._2_Lab02_24520314
{
    [Serializable]
    public class SinhVien
    {
        public string HoTen { get; set; } = "";
        public int MSSV { get; set; } 
        public string DienThoai { get; set; } = "";
        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        public float Diem3 { get; set; }
        public float DiemTB { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string hoTen, int mssv, string dienThoai,
                        float diem1, float diem2, float diem3)
        {
            HoTen = hoTen;
            MSSV = mssv;
            DienThoai = dienThoai;
            Diem1 = diem1;
            Diem2 = diem2;
            Diem3 = diem3;
            DiemTB = 0;
        }
    }
}
