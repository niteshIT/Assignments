using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class MallardDuck:Duck,IDuck
    {
        public override DuckType Type => DuckType.MallardDuck;
        public MallardDuck(string name, int noofwings, int weight)
        {
            Name = name;
            NoofWings = noofwings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Fly fast";
        }
        public string Quack()
        {
            return "Quack loud";
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Number of wings: " + NoofWings);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine(this.Fly());
            Console.WriteLine(this.Quack());
        }
    }
}
