using System;
using System.Collections.Generic;
using System.Text;

namespace laba9._1
{
    class Train : Ts
    {
        private int price;

        public Train(string name, int people, int price) : base(name, people)
        {
            base.Name = name;
            this.People = people;
            this.Price = price;

           
        }

        public int Price { get => price; set => price = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Price = {price}");

        }
    }
}
