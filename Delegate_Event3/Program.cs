using System;
using System.Text;

namespace Delegate_Event3
{
    internal class Program
    {

        class FuncTional
        {
            public event EventHandler eventNhapSo;
            public void MoiNhapSo()
            {
                Console.WriteLine("Mời Nhập Số A :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời Nhập Số B :");
                int b = Convert.ToInt32(Console.ReadLine());
                eventNhapSo.Invoke(this, new ChucNang1(a, b));
            }
        }

        class ChucNang1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }

            public ChucNang1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

        }
        class TinhToan
        {

            public void ThucThiTinhTong(FuncTional fnc)
            {
                fnc.eventNhapSo += Fnc_eventNhapSo1;
            }

            private void Fnc_eventNhapSo1(object sender, EventArgs e)
            {
                ChucNang1 cn1 = (ChucNang1)e;
                Console.WriteLine($"{cn1.a + cn1.b}");
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
