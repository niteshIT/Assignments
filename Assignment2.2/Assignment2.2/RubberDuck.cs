using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class RubberDuck:Duck,IDuck
    {
        public override DuckType Type => DuckType.RubberDuck;
        public RubberDuck(string name, int noofwings, int weight)
        {
            Name = name;
            NoofWings = noofwings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Does not fly";
        }
        public string Quack()
        {
            return "Does not Quack";
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Type: "+ Type);
            Console.WriteLine("Number of wings: " + NoofWings);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine(Fly());
            Console.WriteLine(Quack());
        }
    }
}
