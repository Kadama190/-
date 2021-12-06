using System;
using System.Collections.Generic;
using System.Text;

namespace laba9._1
{
    class Express : Train
    {
        private int speed;
        public Express(string name, int people, int price, int speed) : base(name, people, price)
        {
            base.Name = name;
            this.People = people;
            this.Price = price;

            this.Speed = speed;
        }

        public int Speed { get => speed; set => speed = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Speed = {speed}");

        }
    }
}
