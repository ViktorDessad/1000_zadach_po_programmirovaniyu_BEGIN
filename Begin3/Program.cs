using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSide = 5;
            int secondSide = 8;

            int square = firstSide * secondSide;
            int perimeter = 2 * (firstSide * secondSide);

            Console.WriteLine("Square {0} and perimeter {1}", square,perimeter);
        }
    }
}
