namespace Tana_Tutor_CSharp2
{
    public class Laptop
    {
        public int Malaptop { get; set; }
        public string Tenlaptop { get; set; }
        public double TruongLuong { get; set; }

        public Laptop()
        {

        }
        public string LoiChao(string msg)
        {

            System.Console.WriteLine($"Mời Bạn Nhập {msg}");
            return System.Console.ReadLine();
        }
        public Laptop(int malaptop, string tenlaptop, double truongLuong)
        {
            Malaptop = malaptop;
            Tenlaptop = tenlaptop;
            TruongLuong = truongLuong;
        }

        public void PrintToSrceen()
        {
            System.Console.WriteLine($"Ma LapTop La:{Malaptop},Ten LapTop La:{Tenlaptop},TrongLuong LapTop La:{TruongLuong}");
        }
    }
}
