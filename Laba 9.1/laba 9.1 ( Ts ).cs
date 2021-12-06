using System;
using System.Collections.Generic;
using System.Text;

namespace laba9._1
{
    class Ts
    {
        private string name;
        private  int people;
        public Ts()
        {
            name = "Название Ts";
            people = 0;
        }
        public Ts(string name, int people)
        {
            this.name = name;
            this.people = people;
        }
        public string Name { get => name; set => name = value; }
        public int People { get => people; set => people = value; }
        public void Print()
        {
            Console.WriteLine("Значение полей");
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"People = {people} Чол");

        }
    }
}
