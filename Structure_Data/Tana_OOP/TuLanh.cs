using System;

namespace Tana_OOP
{
    public class TuLanh : Machines
    {


        public int Height { get; set; }
        public int ThoiGianLamMat { get; set; }

        public TuLanh(Guid id, string name, double price, int height, int thoigianlammat) : base(id, name, price)
        {
            Height = height;
            ThoiGianLamMat = thoigianlammat;


        }

        public override string LoiChao(string mess)
        {
            Console.WriteLine($"Mời Bạn Nhập {mess}");
            return Console.ReadLine();
        }

        public override void PrintToSrceen()
        {
            Console.WriteLine("ID Tủ lạnh là {0},Tên Tủ lạnh là {1},Giá Tủ lạnh là {2},Chiều Cao Tủ lạnh là {3},Thời Gian Làm Mát Tủ lạnh là {4}", Id, Price, Name, Height >= 100 ? "Cao Vút" : "Thấp Tè", ThoiGianLamMat > 5 ? "Lâu" : "Kém");
        }
        public void hoc()
        {
            Console.WriteLine("ID Tủ lạnh là {0},Tên Tủ lạnh là {1},Giá Tủ lạnh là {2},Chiều Cao Tủ lạnh là {3},Thời Gian Làm Mát Tủ lạnh là {4}", Id, Price, Name, Height >= 100 ? "Cao Vút" : "Thấp Tè", ThoiGianLamMat > 5 ? "Lâu" : "Kém");
        }
    }
}
