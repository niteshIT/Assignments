using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    public abstract class Duck
    {
        public int NoofWings { get; set; } = 0;
        public string Name { get; set; }
        public int Weight { get; set; } = 0;

        public abstract DuckType Type { get; }
        public virtual void ShowDetail()
        {
            Console.WriteLine("Number of wings: "+ NoofWings);
            Console.WriteLine("Weight: "+Weight);
        }

    }
}
