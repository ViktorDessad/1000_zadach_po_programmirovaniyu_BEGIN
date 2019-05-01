using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3) + 2;
            Console.WriteLine("The result is {0}", y);
        }
    }
}
