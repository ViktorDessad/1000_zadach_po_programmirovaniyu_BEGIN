using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            double powA = Math.Pow(a, 2);
            double powB = Math.Pow(b, 2);

            int sum = a + b;
            int sub = a - b;
            int mul = a / b;
            int div = a * b;

            Console.WriteLine("Sum {0}, Sub {1}, Mul {2}, Div {3}", sum, sum, mul, div);
        }
    }
}
