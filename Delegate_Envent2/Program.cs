using System;
using System.Text;

namespace Delegate_Envent2
{
    public class Program
    {

        public delegate void EnventNhapSo(int a, int b);
        class FuncTional
        {
            public event EnventNhapSo eventNhapSo;
            public void MoiNhapSo()
            {
                Console.WriteLine("Mời Nhập Số A :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời Nhập Số B :");
                int b = Convert.ToInt32(Console.ReadLine());
                eventNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {

            public void ThucThiTinhTong(FuncTional fnc)
            {
                fnc.eventNhapSo += Fnc_eventNhapSo;
            }

            private void Fnc_eventNhapSo(int a, int b)
            {
                Console.WriteLine($"tổng là :{a + b}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            FuncTional funcTional = new FuncTional();
            //nhận ra sự kiện phát đi

            TinhToan tinhToan = new TinhToan();
            tinhToan.ThucThiTinhTong(funcTional);

            //thực thi sự kiện
            funcTional.MoiNhapSo();
        }
    }
}
