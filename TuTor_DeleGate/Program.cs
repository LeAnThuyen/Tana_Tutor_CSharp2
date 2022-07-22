using System;
using System.Text;

namespace TuTor_DeleGate
{
    internal class Program
    {


        //bước 1 tạo 1 delegate
        delegate void UpateFullName(string name);
        //bước 2 tạo class đối tượng
        class Student
        {
            public event UpateFullName namChanged;
            private string name;
            public string Name
            {
                get => name;
                set
                {
                    name = value;
                    //kiểm tra name bị thay đổi
                    if (namChanged != null)
                    {
                        namChanged(name);
                    }
                }
            }


        }

        //học về delegate cơ bản trước đã(gồm delegate func, delegate envent, delegatecallback)
        public delegate string NormalDelegate(string mess);
        public delegate void NormalDelegateMutilcast(string mess);
        //delegate này có kiểu trả về là string và nó cũng nhận kiểu dữ tham số truyền vào là string

        //tiếp đến là delegateCallback//cái này sẽ callback về 1 phương thức nào đấy khi phương thức đấy được thực thi
        public delegate void DelegateCallback(string contentCreator);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ////khởi tạo ra class chứa hàm InRaLoiChao để cho delegate target tới hàm đó
            Program program = new Program();
            ////NormalDelegate normalDelegate = new NormalDelegate(program.InRaLoiChao);

            //////normalDelegate("Thuyên");
            //////System.Console.WriteLine(normalDelegate("Ngân"));

            //////bây giờ cần mutilcast 2 delegate lại với nhau 
            ////NormalDelegateMutilcast normal1 = new NormalDelegateMutilcast(program.Printer);
            ////normal1("Thuyên Yêu");
            ////
            ////NormalDelegateMutilcast normal2 = new NormalDelegateMutilcast(program.Printer2);
            ////normal2("Ngân");
            //////dây gọi là gộp 2 delegate lại như kiểu cộng 2 biên
            ////Console.WriteLine("===============Final==============");
            ////NormalDelegateMutilcast MixMulticast = normal1 + normal2;
            ////MixMulticast("Final");

            // delegate Callback lại 1 hàm nhé

            //DelegateCallback delegateCallbacker = new DelegateCallback(program.forDelegateCallBack);//tham chiếu đến hàm cần callback

            //finalCallback(delegateCallbacker);

            //
            program.fun1 = ThongTin;
            program.fun1(14.5, 156.5, "Thuyen");

            program.fun4 = ThongTin2;
            program.fun4(20, "Dat");

            program.action = ThongTin3;
            program.action("Giang", 69, 90);


            program.func5 = ThongTin5;
            program.func5("Thinh", "PH67818", false);


            //
            //Student st = new Student();
            //st.namChanged += St_namChanged;
            //st.Name = "Thuyen";

        }
        Func<double, double, string, int> fun1;

        Func<int, string, string> fun4;

        Action<string, int, double> action;

        // Predicate<string, string, bool> func3;

        Func<string, string, bool, bool> func5;
        public void forDelegateCallBack(string booking)
        {

            Console.WriteLine($"tên phòng học là {booking}");
        }
        public static void finalCallback(DelegateCallback forDelegateCallBack)
        {
            var mees = "fucing for fun";
            forDelegateCallBack(mees);
        }


        //public string InRaLoiChao(string name)
        //{
        //    System.Console.WriteLine($"Xin Chào {name}");
        //    return "In Tên Thành Công";
        //}
        //public string InRaLoiChao2(string name)
        //{
        //    System.Console.WriteLine($"Xin Chào {name}");
        //    return "In Tên Thành Công";
        //}

        //public void Printer(string mess)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"đây là máy in tên số 1 {mess}");
        //    Console.ResetColor();
        //}
        //public void Printer2(string mess)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"đây là máy in tên số 2 {mess}");
        //    Console.ResetColor();
        //}
        //public static string FUN(int namsinh, string name)
        //{

        //    Console.WriteLine($"Tên là {name},năm sính là {namsinh}");

        //    return "Done";
        //}
        //public static int sotuoi(double cannang, double chieucao, string name)
        //{

        //    Console.WriteLine($"Câng nặng là {cannang},Chiều cao là {chieucao},Tên là {name}");

        //    return 20;
        //}
        //public static bool pre(string name, string masv, bool sex)
        //{

        //    Console.WriteLine("Tên là {0},Mã sinh Viên là {1},giới tính là {2}", name, masv, sex == true ? "Nam" : "Nữ");

        //    return true;
        //}
        //public static void AC(string name, int masv, double mark)
        //{

        //    Console.WriteLine("Tên là {0},Mã sinh Viên là {1},Điểm là {2}", name, masv, mark);


        //}

        private static void St_namChanged(string name)
        {
            Console.WriteLine("Thong báo ra giá trị mới là " + name);
        }



        //giải fun1
        public static int ThongTin(double cannang, double chiuecao, string ten)
        {
            Console.WriteLine($"Can nang la{cannang},Chieu cao la{chiuecao} ,Ten la{ten}");
            return 1;
        }
        //giải fun4
        public static string ThongTin2(int tuoi, string ten)
        {
            Console.WriteLine($"Tuoi sinh vien la{tuoi},Ten la{ten}");
            return "aaaa";
        }
        //giải action
        public static void ThongTin3(string ten, int tuoi, double cannang)
        {
            Console.WriteLine($"Tuoi sinh vien la{tuoi},Ten la{ten},Can nang la{cannang}");

        }

        public static bool ThongTin5(string ten, string masv, bool trangthai)
        {
            Console.WriteLine("ten sinh vien la:{0}, ma sinh vien la{1}, trang thai{2}", ten, masv, trangthai == true ? "Học đi" : "Học Lại");
            return true;
        }

    }
}
