using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleLenght = 123.56;

            double circleRadius = circleLenght / (2 * Math.PI);
            double circleSquare = Math.PI * Math.Pow(circleRadius, 2);

            Console.WriteLine("Radius {0:#.##}, Square {1:#.##}", circleRadius, circleSquare);

        }
    }
}
