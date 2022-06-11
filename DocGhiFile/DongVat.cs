using System;

namespace DocGhiFile
{
    //bắt buộc phải có
    //Serialize
    [Serializable]
    public class DongVat
    {
        public string TenDongVat { get; set; }
        public string TiengKeu { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }


        public DongVat()
        {

        }

        public DongVat(string tenDongVat, string tiengKeu, double canNang, double chieuCao)
        {
            TenDongVat = tenDongVat;
            TiengKeu = tiengKeu;
            CanNang = canNang;
            ChieuCao = chieuCao;

        }

        public void Inramanhinh()
        {
            System.Console.WriteLine($"Ten la:{TenDongVat}," +
                $"tieng keu la:{TiengKeu},Can Nang la:{CanNang},Chieu Cao la:{ChieuCao},");
        }
    }
}
