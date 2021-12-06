using System;
using System.Collections.Generic;
using System.Text;

namespace laba9._1
{
    class Car : Ts
    {
        private int fuel;

        public Car(string name, int people, int fuel) : base(name, people)
        {
            this.Name = name;
            this.People = people;

            this.Fuel = fuel;
        }

        public int Fuel { get => fuel; set => fuel = value; }
        public new void Print()
        {

            base.Print();
            Console.WriteLine($"Fuel = {fuel} Л");

        }
    }
}
