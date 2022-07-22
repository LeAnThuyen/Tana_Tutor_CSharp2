using System;
using System.Text;

namespace Tana_TestExam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LapTopServices lapTopServices = new LapTopServices();
            //lapTopServices.ShowMenu();

            //string utf8_String = "Thuyên";
            //byte[] bytes = Encoding.Default.GetBytes(utf8_String);
            //var x = Encoding.UTF7.GetString(bytes);
            string text = "Some Thuyên string that I am using but Poacher\u2019s shows unicode!";
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            var x = Encoding.Default.GetString(Encoding.Convert(Encoding.Unicode, Encoding.UTF8, textBytes));
            Console.WriteLine(x);
        }
    }
}
