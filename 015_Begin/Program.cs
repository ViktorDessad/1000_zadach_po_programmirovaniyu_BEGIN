using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleSquare = 256.45;

            double circleDiameter = Math.Sqrt(circleSquare / Math.PI) * 2;
            double circleLenght = circleDiameter * Math.PI;

            Console.WriteLine("Diameter {0:#.##}, Lenght {1:#.##}", circleDiameter, circleLenght);
        }
    }
}
