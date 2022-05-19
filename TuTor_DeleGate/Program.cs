using System;
using System.Text;

namespace TuTor_DeleGate
{
    internal class Program
    {



        //học về delegate cơ bản trước đã(gồm delegate func, delegate envent, delegatecallback)
        public delegate string NormalDelegate(string mess);
        public delegate void NormalDelegateMutilcast(string mess);
        //delegate này có kiểu trả về là string và nó cũng nhận kiểu dữ tham số truyền vào là string

        //tiếp đến là delegateCallback//cái này sẽ callback về 1 phương thức nào đấy khi phương thức đấy được thực thi
        public delegate void DelegateCallback(string contentCreator);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //khởi tạo ra class chứa hàm InRaLoiChao để cho delegate target tới hàm đó
            Program program = new Program();
            //NormalDelegate normalDelegate = new NormalDelegate(program.InRaLoiChao);

            ////normalDelegate("Thuyên");
            ////System.Console.WriteLine(normalDelegate("Ngân"));

            ////bây giờ cần mutilcast 2 delegate lại với nhau 
            //NormalDelegateMutilcast normal1 = new NormalDelegateMutilcast(program.Printer);
            //normal1("Thuyên Yêu");

            //NormalDelegateMutilcast normal2 = new NormalDelegateMutilcast(program.Printer2);
            //normal2("Ngân");
            ////dây gọi là gộp 2 delegate lại như kiểu cộng 2 biên
            //Console.WriteLine("===============Final==============");
            //NormalDelegateMutilcast MixMulticast = normal1 + normal2;
            //MixMulticast("Final");

            // delegate Callback lại 1 hàm nhé

            DelegateCallback delegateCallbacker = new DelegateCallback(program.forDelegateCallBack);//tham chiếu đến hàm cần callback

            finalCallback(delegateCallbacker);
        }

        public string InRaLoiChao(string name)
        {
            System.Console.WriteLine($"Xin Chào {name}");
            return "In Tên Thành Công";
        }
        public string InRaLoiChao2(string name)
        {
            System.Console.WriteLine($"Xin Chào {name}");
            return "In Tên Thành Công";
        }

        public void Printer(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"đây là máy in tên số 1 {mess}");
            Console.ResetColor();
        }
        public void Printer2(string mess)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"đây là máy in tên số 2 {mess}");
            Console.ResetColor();
        }

        public void forDelegateCallBack(string booking)
        {
            Console.WriteLine($"tên phòng học là {booking}");
        }
        public static void finalCallback(DelegateCallback forDelegateCallBack)
        {
            var mees = "fucing for fun";
            forDelegateCallBack(mees);
        }

    }
}
