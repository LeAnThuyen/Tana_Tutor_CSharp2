using System;

namespace Tana_OOP
{

    //đây là lớp cha(lớp trừu tượng)
    //thằng cha còn tủ lạnh là con
    public abstract class Machines
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Machines()
        {

        }

        protected Machines(Guid id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract string LoiChao(string mess);
        public abstract void PrintToSrceen();

        public void INra()
        {
            Console.WriteLine("chào các bạn học tutor C#2");
        }

    }
}
