using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Exercise10
{
    static class extenstion
    {
        public static bool IsOdd(this Class1 c, int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this Class1 c, int number)
        {
            return number % 2 == 0;
        }

        public static bool IsPrime(this Class1 c, int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDivisibleBy(this Class1 c, int number, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            return number % divisor == 0;
        }
    }
}

