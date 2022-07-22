using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChuaDeThiThu
{
    public class ServiceForAnother
    {

        Func<string, string> funcer;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string _path = @"C:\Users\Asus\source\repos\vpchemistry\Tana_Tutor_CSharp2\ChuaDeThiThu\TextFile1.txt";
        public ServiceForAnother()
        {
            funcer = loichao;
            funcer("thuyen");
            funcer("thuyen");
            funcer("thuyen");
            funcer("thuyen");

        }

        public string loichao(string mess)
        {

            Console.WriteLine($"moi ban nhap :{mess}");
            return Console.ReadLine();
        }


        //public List<T> openfile<T>()
        //{
        //    List<T> values = new List<T>();
        //    _fs = new FileStream(_path, FileMode.Create);
        //    _bf = new BinaryFormatter();
        //    _bf.Serialize(_fs,);
        //    return values;
        //}

    }
}
