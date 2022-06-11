using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DocGhiFile
{
    public class DongVatServices
    {
        private string _path = @"C:\Users\Asus\source\repos\vpchemistry\Tana_Tutor_CSharp2\DocGhiFile\FileDocGhiDoiTuong.txt";
        private FileStream _fs;
        private BinaryFormatter _bf;
        private List<DongVat> _lstDongvat;
        private DongVat _dv;
        private string _inputValues;
        public DongVatServices()
        {
            _lstDongvat = new List<DongVat>();
        }
        public void AddDongVat()
        {

            _inputValues = MoiBan("so luong nyc ban muon nhap");
            //
            for (int i = 0; i < Convert.ToInt32(_inputValues); i++)
            {

                _dv = new DongVat();
                //áp dụng phương thức trả về

                _dv.TenDongVat = MoiBan("Nhap Ten");
                _dv.TiengKeu = MoiBan("Nhap Tieng keu");
                _dv.CanNang = Convert.ToDouble(MoiBan("Nhap Can Nang"));
                _dv.ChieuCao = Convert.ToDouble(MoiBan("Nhap Chieu cao"));
                _lstDongvat.Add(_dv);
            }
            ShowMenu();
        }
        public string MoiBan(string mess)
        {

            Console.WriteLine($"Moi Ban Nhap {mess}");
            return Console.ReadLine();
        }

        public void GhiFile()
        {
            //khởi tạo
            _fs = new FileStream(_path, FileMode.Create);
            _bf = new BinaryFormatter();
            //
            _bf.Serialize(_fs, _lstDongvat);
            _fs.Close();
            Console.WriteLine("Ghi File Thanh Cong");
            ShowMenu();
        }

        public void DocFile()
        {

            _fs = new FileStream(_path, FileMode.Open);
            _bf = new BinaryFormatter();

            var getDongVat = _bf.Deserialize(_fs);
            _lstDongvat = (List<DongVat>)getDongVat;
            _fs.Close();
            foreach (var x in _lstDongvat)
            {
                x.Inramanhinh();
            }
            Console.WriteLine("Doc File Thanh Cong");
            ShowMenu();
        }
        public void XuatDuLieu()
        {
            foreach (var x in _lstDongvat)
            {
                x.Inramanhinh();
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
                    AddDongVat();
                    break;
                case 2:
                    GhiFile();
                    break;
                case 3:
                    DocFile();
                    break;
                case 4:
                    XuatDuLieu();

                    break;


                default:
                    Console.WriteLine("☆*: .｡. o(≧▽≦)o .｡.:*☆");
                    Console.WriteLine("Chọn cũng ngu");
                    break;

            }
        }

    }
}
