using System;
using System.Text;

namespace Tana_Tutor_CSharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            LapTopServices _lapSer = new LapTopServices();

            _lapSer.ShowMenu();







            //EnventCsharpDelegate myApp = new EnventCsharpDelegate();

            //Console.WriteLine("User Click on Open Button ....");

            //// Mô phỏng openButton bị click
            //myApp.openButton.Clicked();

            //Console.WriteLine("\n\n");
            //Console.WriteLine("User Click on Save Button ....");

            //// Mô phỏng saveButton bị click
            //myApp.saveButton.Clicked();
        }
    }
}
