using System;

namespace OnTapDocGhiFile
{
    [Serializable]
    public class NguoiYeuCu
    {

        public string TenNYC { get; set; }
        public double vong1 { get; set; }
        public double vong2 { get; set; }
        public double vong3 { get; set; }
        public int SoThuTu { get; set; }
        public int Tuoi { get; set; }
        public bool GioiTinh { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }

        public NguoiYeuCu()
        {

        }

        public NguoiYeuCu(string tenNYC, double vong1, double vong2, double vong3, int soThuTu, int tuoi, bool gioiTinh, double canNang, double chieuCao)
        {
            TenNYC = tenNYC;
            this.vong1 = vong1;
            this.vong2 = vong2;
            this.vong3 = vong3;
            SoThuTu = soThuTu;
            Tuoi = tuoi;
            GioiTinh = gioiTinh;
            CanNang = canNang;
            ChieuCao = chieuCao;
        }

        public void InraManHinh()
        {
            System.Console.WriteLine("Ten La :{0},Tuoi La :{1}" +
                ",Vong 1 La :{2}, Vong 2 La :{3}" +
                ", Vong 3 La :{4},STT La :{5}," +
                " Gioi Tinh La :{6},Can Nang La :{7}, Chieu Cao La :{8},", TenNYC, Tuoi,
                vong1, vong2, vong3, SoThuTu, GioiTinh == true ? "Nam" : "Nữ", CanNang, ChieuCao);
        }


    }
}
