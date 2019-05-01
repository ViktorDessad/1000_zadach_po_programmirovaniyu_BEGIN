using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 965;
            int b = 4324;

            double res = Math.Sqrt(a * b);

            Console.WriteLine("The result is {0}", res);
            Console.WriteLine("The result is " + res);
            Console.WriteLine($"The result is {Math.Sqrt(a*b)}");
        }
    }
}
