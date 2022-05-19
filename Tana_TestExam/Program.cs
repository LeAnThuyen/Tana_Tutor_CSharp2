using System;
using System.Text;

namespace Tana_TestExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            LapTopServices lapTopServices = new LapTopServices();
            lapTopServices.ShowMenu();
        }
    }
}
