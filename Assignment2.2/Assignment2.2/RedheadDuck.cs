using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class RedheadDuck:Duck,IDuck
    {
        public override DuckType Type => DuckType.RedheadDuck;
        public RedheadDuck(string name, int noofwings,int weight)
        {
            Name = name;
            NoofWings = noofwings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Fly slow";
        }
        public string Quack()
        {
            return "Quack mild";
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Number of wings: " + NoofWings);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine(Fly());
            Console.WriteLine(Quack());
        }
    }
}
