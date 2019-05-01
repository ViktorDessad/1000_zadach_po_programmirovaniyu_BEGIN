using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin7
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 12;

            double circleLenght = 2 * Math.PI * radius;
            double circleSquare = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The result is Lenght {0}, Square {1}", circleLenght, circleSquare);
        }
    }
}
