namespace ThiThu_Deso2
{
    public class SinhVien
    {
        public int MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public float DiemCsharp { get; set; }
        public int NamSinh { get; set; }
        public int GioiTinh { get; set; }
        public SinhVien()
        {

        }

        public SinhVien(int maSinhVien, string tenSinhVien, float diemCsharp, int namSinh, int gioiTinh)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            DiemCsharp = diemCsharp;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
        }

        public void PrintToSrceen()
        {
            System.Console.WriteLine("MaSinhVien la{0}, Ten Sinh Vien La:{1}, Năm Sinh Là {2},Diểm CSharp là :{3},Giới Tính Là:{4}", MaSinhVien, TenSinhVien, NamSinh, DiemCsharp, GioiTinh == 1 ? "Nam" : "Nữ");
        }
    }
}
