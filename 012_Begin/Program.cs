using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstKatet = 12;
            int secondKatet = 15;

            double hypotenuse = Math.Sqrt(Math.Pow(firstKatet, 2) + Math.Pow(secondKatet, 2));
            double perimeter = firstKatet + secondKatet + hypotenuse;

            Console.WriteLine($"Perimeter {perimeter}, Hypotenuse {hypotenuse}");
            Console.WriteLine("Perimeter {0:#.##}, Hypotenuse {1:#.##}", perimeter, hypotenuse);
        }
    }
}
