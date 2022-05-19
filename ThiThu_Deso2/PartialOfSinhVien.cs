using System;

namespace ThiThu_Deso2
{
    partial class ServiceCollage
    {

        private int valueCases;

        public void ShowMenu()
        {
            System.Console.WriteLine("====================Menu====================");
            System.Console.WriteLine("1.Chức Măng Thêm Sinh Viên");
            System.Console.WriteLine("2.Xuất");
            System.Console.WriteLine("3.Lưu& Đọc file");
            System.Console.WriteLine("4.Tìm Kiếm");
            System.Console.WriteLine("5.Xóa Lap");
            System.Console.WriteLine("6.Sắp Xếp Sinh Viên");

            System.Console.WriteLine("====================The End====================");
            System.Console.WriteLine("Mời Bạn Nhập Chức Năng");
            valueCases = Convert.ToInt32(System.Console.ReadLine());
            switch (valueCases)
            {
                case 1:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 1 /n");
                    AddSinhVien();
                    break;
                case 2:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 2 /n");
                    Printer();
                    break;
                case 3:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 3 /n");

                    break;
                case 4:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 4 /n");

                    break;
                case 5:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 5 /n");
                    DeleUSeLInq();
                    break;
                case 6:
                    Console.WriteLine("Chào Mừng Bạn Đến Với Chức Năng 6s /n");
                    SortedList();
                    break;

                default:
                    Console.WriteLine("Chọn Cũng Ngu╰(*°▽°*)╯");
                    break;
            }
        }




        public string StringInput(string mess)
        {

            Console.WriteLine($"Mời bạn Nhập {mess}");
            return Console.ReadLine();
        }




    }
}
