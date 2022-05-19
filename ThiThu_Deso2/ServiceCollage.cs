using System;
using System.Collections.Generic;
using System.Linq;

namespace ThiThu_Deso2
{
    partial class ServiceCollage
    {
        private List<SinhVien> _lstSinhVien;
        private SinhVien _sv;
        private string _inputValues;
        private string conti;


        public ServiceCollage()
        {
            _lstSinhVien = new List<SinhVien>();
        }
        public void AddSinhVien()
        {
            try
            {
                do
                {
                    _inputValues = StringInput("Số Sinh Viên Muốn Nhập");
                    for (int i = 0; i < Convert.ToInt32(_inputValues); i++)
                    {
                        _sv = new SinhVien();
                        string masv = "";

                        do
                        {
                            Console.WriteLine("Mời Bạn Nhập mã sinh viên");
                            masv = Console.ReadLine();
                            Console.WriteLine(Checker(masv));

                        } while (!Checker(masv));// nếu trả về bằng false thì bắt buộc phải nhập lại



                        _sv.MaSinhVien = Convert.ToInt32(masv);
                        _sv.TenSinhVien = Convert.ToString(StringInput("Tên"));
                        _sv.NamSinh = Convert.ToInt32(StringInput("Năm Sinh"));

                        _sv.DiemCsharp = float.Parse(StringInput("Điểm Csharp"));
                        _sv.GioiTinh = Convert.ToInt32(StringInput("Giới Tính"));
                        _lstSinhVien.Add(_sv);


                    }
                    Console.WriteLine("bạn có muốn thêm sinh viên hay không y/n");
                    conti = Console.ReadLine();
                    ShowMenu();

                } while (!(conti == "n"));

                ShowMenu();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public bool Checker(string msv)
        {
            if (String.IsNullOrEmpty(msv))
            {

                return false;
            }
            if (_lstSinhVien.Any(c => c.MaSinhVien == Convert.ToInt32(msv)))
            {
                return false;
            }
            return true;
        }
        public void Printer()
        {
            foreach (var x in _lstSinhVien)
            {
                x.PrintToSrceen();
            }
        }

        public void DeleUSeLInq()
        {
            string masv = StringInput("Mã Sinh Viên Muốn Xóa");
            if (_lstSinhVien.Any(c => c.MaSinhVien == Convert.ToInt32(masv)))
            {
                int indexer = _lstSinhVien.FindIndex(c => c.MaSinhVien == Convert.ToInt32(masv));
                _lstSinhVien.RemoveAt(indexer);
                string tensv = _lstSinhVien.Where(c => c.MaSinhVien == Convert.ToInt32(masv)).Select(c => c.TenSinhVien).FirstOrDefault();
                Console.WriteLine($"Xóa thành công sinh viên {tensv}");
                return;
            }
            Console.WriteLine("Không tìm thấy sinh viên bạn vừa nhập");

        }
        public void SortedList()
        {
            Console.WriteLine("=============Final List=============");
            foreach (var x in _lstSinhVien.Where(c => c.NamSinh - 2022 <= -20 && c.DiemCsharp >= 5 && c.TenSinhVien.Contains("T")))
            {
                x.PrintToSrceen();
            }
        }
        public void DescessingList()
        {
            Console.WriteLine("=============Final List=============");
            foreach (var x in _lstSinhVien.OrderByDescending(c => c.TenSinhVien))
            {
                x.PrintToSrceen();
            }
        }

    }
}
