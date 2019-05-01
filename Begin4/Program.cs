using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin4
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter = 23.45d;
            double PI = Math.PI;

            double circleLenght = diameter * PI;

            Console.WriteLine("The result is {0}",circleLenght);
        }
    }
}
