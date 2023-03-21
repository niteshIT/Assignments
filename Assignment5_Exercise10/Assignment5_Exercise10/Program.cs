using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Class1();
            Console.WriteLine(obj.function1());
            Console.WriteLine(obj.function2());
            Console.WriteLine(obj.IsEven(10));
            Console.WriteLine(obj.IsOdd(10));
            Console.WriteLine(obj.IsDivisibleBy(20, 10));
            Console.WriteLine(obj.IsPrime(20));
            Console.ReadLine();






        }
    }
}
