using System;

namespace Tana_TestExam
{
    //thêm chỉ thị này vào để đọc file
    [Serializable]
    public class Laptop
    {


        public int MaLapTop { get; set; }
        public string Ten { get; set; }
        public double TrongLuong { get; set; }
        public string DanhGia { get; set; }
        public Laptop()
        {

        }

        public Laptop(int maLapTop, string ten, double trongLuong, string danhGia)
        {
            MaLapTop = maLapTop;
            Ten = ten;
            TrongLuong = trongLuong;
            DanhGia = danhGia;
        }

        public void PrintToScreen()
        {
            System.Console.WriteLine("Mã LapTop Là: {0}, Tên LapTop Là: {1},Trọng Lượng LapTop Là: {2},DanhGia LapTop Là: {3}", MaLapTop, Ten, TrongLuong > 2 ? "Nặng" : "Nhẹ", DanhGia);
        }

        internal static object Tolist()
        {
            throw new NotImplementedException();
        }
    }
}
