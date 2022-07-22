using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Tana_TestExam
{
    public partial class LapTopServices
    {

        private Laptop _lt;
        private List<Laptop> _lstLap;
        private string _inpuValues;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string _path = @"C:\Users\Asus\source\repos\vpchemistry\Tana_Tutor_CSharp2\Tana_TestExam\TanaLap.txt";
        public delegate bool Delegater(string mess);
        public LapTopServices()
        {
            _lt = new Laptop();

            _lstLap = new List<Laptop>();

        }

        //public , private, protected, internal....
        public void AddLapTop()
        {
            //khởi tạo 1 cái delegate 

            do
            {
                _inpuValues = LoiChao("Số Lượng Lap Muốn Thêm");
                for (int i = 0; i < Convert.ToInt32(_inpuValues); i++)
                {
                    int Indexer = _lstLap.Count + 1;
                    _lt = new Laptop();
                    Console.WriteLine($"========lap Số{Indexer}======== ");
                    string maLap = "";
                    Delegater delegater = new Delegater(CheckMa);
                    do
                    {
                        maLap = LoiChao("Mã Lap");
                        Console.WriteLine(CheckMa(maLap));
                    } while (!delegater(maLap));
                    _lt.MaLapTop = Convert.ToInt32(maLap);
                    _lt.Ten = LoiChao("Tên Lap");
                    _lt.TrongLuong = Convert.ToDouble(LoiChao("trọng lượng Lap"));
                    _lt.DanhGia = LoiChao("Đánh Giá");
                    _lstLap.Add(_lt);

                }
                Console.WriteLine("bạn có muốn nhập thêm hay không y/n");
                _inpuValues = Console.ReadLine();
            } while (!(_inpuValues == "n"));
            //hàm này được thực thi khi và chỉ khi input khác n
            ShowMenu();
        }


        public string LoiChao(string mess)
        {
            Console.WriteLine($"Mời Bạn Nhập{mess}");
            return Console.ReadLine();
        }
        public int Kkaka(string mess)
        {
            Console.WriteLine($"Mời Bạn Nhập{mess}");
            return Convert.ToInt32(Console.ReadLine());
        }
        public string DangKi(string tk, string mk)
        {
            //hajaskkaska
            string mess = "";
            if (tk == "thuyen" && mk == "abac")
            {

                return "Đăng nhập thành công";

            }
            else
            {

                return "Đăng nhập thành thất bại";

            }
            return "Đăng kí thành công";
        }

        public void Laymess()
        {
            string getmess = DangKi("thuyen", "abac1");
            Console.WriteLine(getmess);
        }
        public bool CheckMa(string malap)
        {
            if (Regex.IsMatch(malap, @"[0-9]+") == false)
            {
                return false;
            }
            return true;
        }

        public void ExportLap()
        {
            _inpuValues = LoiChao("chọn 1.là xuất 1 dối tượng// 2.cả danh sách");


            switch (Convert.ToInt32(_inpuValues))
            {
                case 1:
                    _lt.PrintToScreen();
                    break;
                case 2:
                    foreach (var x in _lstLap)
                    {
                        x.PrintToScreen();
                    }
                    break;
                default:
                    break;
            }
            ShowMenu();
        }
        public List<Laptop> Shorter()
        {
            Console.WriteLine("đây là chức năng sắp xếp giảm dần theo tên");
            _lstLap = _lstLap.OrderByDescending(c => c.Ten).ToList();
            Console.WriteLine("Sắp xếp thành công");
            return _lstLap;
            ShowMenu();
        }

        public void GhiFile()
        {
            Console.WriteLine("chào mừng bạn đến với chức năng ghi file");
            _fs = new FileStream(_path, FileMode.Create);//khờ tạo ra filestream để ghi file
            _bf = new BinaryFormatter();// 
            _bf.Serialize(_fs, _lstLap);
            _fs.Close();
            Console.WriteLine("Ghi File Thành Công");
            ShowMenu();
        }
        public void DocFile()
        {
            Console.WriteLine("chào mừng bạn đến với chức năng đọc file");
            _fs = new FileStream(_path, FileMode.Open);//khờ tạo ra filestream để mở file cần đọc
            _bf = new BinaryFormatter();// 
            var getterData = _bf.Deserialize(_fs);//dọc đối tượng vừa ghi
            _lstLap = new List<Laptop>();
            _lstLap = (List<Laptop>)getterData;//convetr về list
            _fs.Close();//đóng file cần đọc
            foreach (var x in _lstLap)
            {
                x.PrintToScreen();
            }
            Console.WriteLine("dọc file File Thành Công");
            ShowMenu();
        }
        public void DeleALl()
        {
            //đếm ra số lượng phần từ đã xóa
            int counter = counter = _lstLap.RemoveAll(c => c.Ten.StartsWith("A") || c.Ten.StartsWith("a")); ;
            Console.WriteLine("đây là chức năng xóa tên bắt đầu bằng A hoặc a");


            foreach (Laptop x in _lstLap.Where(c => c.MaLapTop == 1))
            {

                _lstLap.Remove(x);

            }

            Console.WriteLine($"Xóa Thành Công số phần từ là {counter} ");
            ShowMenu();
        }
        public List<T> lstGenneric<T>()
        {
            List<T> lstT = new List<T>();

            //khai báo ra 1 list genneric để chút gán;
            return lstT;
        }
    }
}
