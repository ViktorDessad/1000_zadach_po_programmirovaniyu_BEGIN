using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine("The result is {0}", y);
        }
    }
}
