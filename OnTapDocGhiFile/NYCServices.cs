using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace OnTapDocGhiFile
{
    public class NYCServices
    {
        private string _path = @"C:\Users\Asus\source\repos\vpchemistry\Tana_Tutor_CSharp2\OnTapDocGhiFile\FileGhiNYC.txt";
        private FileStream _fs;
        private BinaryFormatter _bf;
        private List<NguoiYeuCu> _lstNYC;
        private NguoiYeuCu _nyc;
        private string _inputValues;


        public NYCServices()
        {
            _lstNYC = new List<NguoiYeuCu>();
        }

        public void AddNyc()
        {
            _inputValues = MoiBan("so luong nyc ban muon nhap");
            //
            for (int i = 0; i < Convert.ToInt32(_inputValues); i++)
            {

                _nyc = new NguoiYeuCu();


                Console.WriteLine("Moi Ban Nhap ten");
                string ten = Console.ReadLine();
                while (CheckSo(ten))
                {
                    Console.WriteLine("Moi ban Nhap Lai");
                    ten = Console.ReadLine();

                }
                _nyc.TenNYC = ten;
                //_nyc.Tuoi = Convert.ToInt32(MoiBan("Tuoi NYC"));
                //_nyc.vong1 = Convert.ToDouble(MoiBan("Vong 1 NYC"));
                //_nyc.vong2 = Convert.ToDouble(MoiBan("Vong 2 NYC"));
                //_nyc.vong3 = Convert.ToDouble(MoiBan("Vong 3 NYC"));
                //_nyc.SoThuTu = Convert.ToInt32(MoiBan("So Thu Tu NYC"));
                //_nyc.GioiTinh = Convert.ToBoolean(MoiBan("Gioi Tinh NYC"));
                //_nyc.CanNang = Convert.ToDouble(MoiBan("Can Nang NYC"));
                //_nyc.ChieuCao = Convert.ToDouble(MoiBan("Chieu Cao NYC"));
                _lstNYC.Add(_nyc);


            }
            ShowMenu();
        }
        public bool CheckSo(string ten)
        {
            if (Regex.IsMatch(ten, @"[0-9]+"))
            {
                return true;
            }
            return false;
        }
        public string MoiBan(string mess)
        {

            Console.WriteLine($"Moi Ban Nhap {mess} ");
            return Console.ReadLine();
        }

        public void GhiFile()
        {
            _fs = new FileStream(_path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, _lstNYC);
            _fs.Close();
            ShowMenu();
        }

        public void DocFile()
        {
            _fs = new FileStream(_path, FileMode.Open);
            _bf = new BinaryFormatter();
            var getdata = _bf.Deserialize(_fs);
            _lstNYC = (List<NguoiYeuCu>)getdata;
            _fs.Close();
            ShowMenu();
        }
        public void DocFile2()
        {
            _fs = new FileStream(_path, FileMode.Open);
            _bf = new BinaryFormatter();
            var getdata = _bf.Deserialize(_fs);
            _lstNYC = (List<NguoiYeuCu>)getdata;
            _fs.Close();
            foreach (var x in _lstNYC)
            {
                x.InraManHinh();
            }
            ShowMenu();
        }
        public void ShowMenu()
        {

            Console.WriteLine("========menu=======");
            Console.WriteLine("1.them");
            Console.WriteLine("2.ghi file");
            Console.WriteLine("3.doc file");
            Console.WriteLine("4.in ra ma hinh");
            Console.WriteLine("moi ban chon chuc nang");
            _inputValues = Console.ReadLine();

            switch (Convert.ToInt32(_inputValues))
            {
                case 0:
                    break;
                case 1:
                    AddNyc();
                    break;
                case 2:
                    GhiFile();
                    break;
                case 3:
                    DocFile();
                    break;
                case 4:
                    XuatDanhSach();

                    break;
                case 5:
                    DocFile2();

                    break;

                default:
                    Console.WriteLine("☆*: .｡. o(≧▽≦)o .｡.:*☆");
                    Console.WriteLine("Chọn cũng ngu");
                    break;

            }
        }


        public void XuatDanhSach()
        {
            foreach (var x in _lstNYC)
            {
                x.InraManHinh();
            }
            ShowMenu();
        }
    }
}
