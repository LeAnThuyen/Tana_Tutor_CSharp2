using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tana_Tutor_CSharp2
{
    partial class LapTopServices
    {
        public delegate string Delegater(string Inputvalues);
        private int _inputValues;
        private string msgAdd;
        private List<Laptop> _lstLapTop;
        private Laptop _LapTop;

        public LapTopServices()
        {
            _lstLapTop = new List<Laptop>();
            _LapTop = new Laptop();

        }

        public void AddCollage()
        {
            do
            {
                Delegater delegater = new Delegater(_LapTop.LoiChao);
                _inputValues = Convert.ToInt32(delegater("Nhập số lượng muốn thêm"));
                for (int i = 0; i < _inputValues; i++)
                {
                    //khới tạo lại mới đối tượng sau mỗi lần thêm Cần lưu ý
                    _LapTop = new Laptop();

                    Console.WriteLine($"Lap số {_lstLapTop.Count + 1}");
                    _LapTop.Malaptop = _lstLapTop.Count + 1;
                    //tên

                    _LapTop.Tenlaptop = delegater("Tên LapTop");
                    //trong lượng
                    string testValues = delegater("Trọng Lượng LapTop");
                    if (Regex.IsMatch(Convert.ToString(testValues), @"[0-9]+") == false)
                    {
                        Console.WriteLine("Mời bạn nhập lại giá trị không được chấp thuận");
                        delegater("Trọng Lượng LapTop");
                        return;
                    }
                    _LapTop.TruongLuong = Convert.ToDouble(testValues);


                    _lstLapTop.Add(_LapTop);
                    Console.WriteLine("---------");
                }
                Console.WriteLine("Bạn có muốn thêm sinh viên nữa hay không? y/n: ");
                msgAdd = System.Console.ReadLine(); ;
            } while (!(msgAdd == "n"));
            ShowMenu();
        }


        public void FindMyCollage()
        {
            Delegater delegater = new Delegater(_LapTop.LoiChao);
            int maLap = Convert.ToInt32(delegater("mã laptop cần tìm là:"));

            if (_lstLapTop.Any(c => c.Malaptop == maLap) == true)
            {
                string tenLap = _lstLapTop.Where(c => c.Malaptop == maLap).Select(c => c.Tenlaptop).FirstOrDefault();
                Console.WriteLine($"kết quản bạn muốm tìm là : {tenLap}");
            }
            else
            {
                Console.WriteLine("kết quản bạn muốm tìm không đúng");
            }

            ShowMenu();
        }
        public void removeLap()
        {
            Delegater delegater = new Delegater(_LapTop.LoiChao);
            int ma = Convert.ToInt32(delegater("Mã LapTop Muốn Xóa"));
            int maLap = _lstLapTop.FindIndex(c => c.Malaptop == ma);
            if (maLap == -1)
            {
                Console.WriteLine("Mã LapTop Bạn Nhập Không Tồn Tại");
            }
            else
            {
                _lstLapTop.RemoveAt(maLap);
                string tenlap = _lstLapTop.Where(c => c.Malaptop == maLap).Select(c => c.Tenlaptop).FirstOrDefault();

                Console.WriteLine($"Chúc mừng bạn đã xóa thành công {tenlap}");
            }
            ShowMenu();
        }
        public void inRaman()
        {
            foreach (var x in _lstLapTop)
            {
                x.PrintToSrceen();
                //Console.WriteLine($"Code{ x.Malaptop} , Tên{x.Tenlaptop}, Cân{x.TruongLuong}");
            }
            ShowMenu();
        }
        public string thamChieuGeneric<T>(ref T a)
        {
            T temp = a;
            string ten = "Không có cái tên nào như thế này cả";
            if (_lstLapTop.Any(c => c.Malaptop == Convert.ToInt32(temp)))
            {
                return ten = _lstLapTop.Where(c => c.Malaptop == Convert.ToInt32(temp)).Select(c => c.Tenlaptop).FirstOrDefault();
            }


            return ten;
        }
        public void findIndex()
        {
            Delegater delegater = new Delegater(_LapTop.LoiChao);
            int findID = Convert.ToInt32(delegater(" ID Muốn Tìm"));

            Console.WriteLine(thamChieuGeneric<int>(ref findID));
            ShowMenu();
        }
        public void SortedList()
        {
            Delegater delegater = new Delegater(_LapTop.LoiChao);
            string chose = delegater("Có muốn sắp xếp lại listlaptop theo thứ tự giảm dần hay không y/n");
            if (_lstLapTop.Count == 0)
            {
                Console.WriteLine("bạn chưa có laptop nào cả vui lòng thêm để thực hiện chức năng");
                ShowMenu();
            }
            if (chose == "y")
            {
                foreach (var x in _lstLapTop.OrderByDescending(c => c.TruongLuong))
                {
                    x.PrintToSrceen();
                }
            }
            else
            {
                ShowMenu();
            }
        }
    }
}
