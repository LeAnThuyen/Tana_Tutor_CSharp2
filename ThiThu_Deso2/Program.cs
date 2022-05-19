using System;
using System.Text;

namespace ThiThu_Deso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceCollage serviceCollage = new ServiceCollage();
            serviceCollage.ShowMenu();
        }
    }
}
