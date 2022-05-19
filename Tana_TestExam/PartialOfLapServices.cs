using System;

namespace Tana_TestExam
{
    public partial class LapTopServices
    {

        public void ShowMenu()
        {
            System.Console.WriteLine("=======Menu======");
            System.Console.WriteLine("1.Thêm lap");
            System.Console.WriteLine("2.Xuất lap");
            System.Console.WriteLine("3.Sắp Xếp lap");
            System.Console.WriteLine("4.Xóa lap Theo A hoặc a");
            System.Console.WriteLine("5.Ghi File");
            System.Console.WriteLine("6.Đọc");
            System.Console.WriteLine("0.Thoát");
            System.Console.WriteLine("Mời Bạn Chọn Chương Trình");
            _inpuValues = Console.ReadLine();
            switch (Convert.ToInt32(_inpuValues))
            {
                case 0:
                    break;
                case 1:
                    AddLapTop();
                    break;
                case 2:
                    ExportLap();
                    break;
                case 3:
                    Shorter();
                    break;
                case 4:
                    DeleALl();

                    break;
                case 5:
                    GhiFile();

                    break;
                case 6:
                    DocFile();
                    break;
                default:
                    Console.WriteLine("☆*: .｡. o(≧▽≦)o .｡.:*☆");
                    Console.WriteLine("Chọn cũng ngu");
                    break;

            }


        }



    }
}
