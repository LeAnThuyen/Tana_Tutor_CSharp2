using System;

namespace Tana_Tutor_CSharp2
{

    partial class LapTopServices
    {
        private int valueCases;

        public void ShowMenu()
        {
            System.Console.WriteLine("====================Menu====================");
            System.Console.WriteLine("1.Chức Măng Thêm lap");
            System.Console.WriteLine("2.Xuất");
            System.Console.WriteLine("3.Lưu& Đọc file");
            System.Console.WriteLine("4.Tìm Kiếm");
            System.Console.WriteLine("5.Xóa Lap");
            System.Console.WriteLine("6.Sắp Xếp Lap");
            System.Console.WriteLine("7.Tìm Kiếm");
            System.Console.WriteLine("====================The End====================");
            System.Console.WriteLine("Mời Bạn Nhập Chức Năng");
            valueCases = Convert.ToInt32(System.Console.ReadLine());
            switch (valueCases)
            {
                case 1:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 1 /n");
                    AddCollage();
                    break;
                case 2:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 2 /n");
                    inRaman();
                    break;
                case 3:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 3 /n");
                    AddCollage();
                    break;
                case 4:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 4 /n");
                    FindMyCollage();
                    break;
                case 5:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 5 /n");
                    removeLap();
                    break;
                case 6:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 6s /n");
                    SortedList();
                    break;
                case 7:
                    Console.WriteLine("Chào Mừng Bạn Đế nVới Chức Năng 7 /n");
                    findIndex();
                    break;
                default:
                    Console.WriteLine("Chọn Cũng Ngu╰(*°▽°*)╯");
                    break;
            }
        }

    }
}
