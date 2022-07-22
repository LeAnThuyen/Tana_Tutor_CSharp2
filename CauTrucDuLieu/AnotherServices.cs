using System;
using System.Collections.Generic;

namespace CauTrucDuLieu
{
    public class AnotherServices
    {

        private List<Another13> _list;
        private Another13 _An;
        private string _input;
        public AnotherServices()
        {
            _list = new List<Another13>();

        }
        public string preInput(string mess)
        {
            System.Console.WriteLine($"Please type your input +{mess}");
            return System.Console.ReadLine();
        }
        public void Adder()
        {
            do
            {
                _input = preInput("so sinh vien");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _An = new Another13();
                    Console.WriteLine($"Sinh vien thu {_list.Count + 1}");
                    _An.Id = Convert.ToInt32(preInput("ID"));
                    _An.Ten = Convert.ToString(preInput("Ten Sinh Vien"));
                    _An.CanNang = Convert.ToDouble(preInput("Can Nang"));
                    _list.Add(_An);

                }
                Console.WriteLine("Bạn có muốn nhập tiếp hay không y/n");
                _input = Console.ReadLine();
            } while (_input != "n");
        }

        public void InRa()
        {
            foreach (var x in _list)
            {
                x.PrintToScreen();
            }
        }

        public Array Swaper()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            return numbers;
        }
        public void ThamChieu()
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"truoc khi tham chieu {numbers[i]}");
            }
            Console.WriteLine("====================================");
            hahahah(ref numbers[0], ref numbers[1], ref numbers[2], ref numbers[3], ref numbers[4]);
            Console.WriteLine("Sau khi tham chieu la :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sau khi tham chieu {numbers[i]}");
            }
        }
        public void hahahah(ref int a, ref int b, ref int c, ref int d, ref int e)
        {
            //sắp xếp lại mảng(1-5,2-4,3)
            int temp = a;
            a = e;
            e = temp;
            //
            int temp2 = b;
            b = d;
            d = temp2;


        }
    }
}
