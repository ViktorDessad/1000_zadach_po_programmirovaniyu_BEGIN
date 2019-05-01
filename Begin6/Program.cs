using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeSide = 5;

            double cubeSize = Math.Pow(cubeSide, 3);
            double cubeSquare = 6 * Math.Pow(cubeSide, 2);

            Console.WriteLine("The result: Size - {0} cm, Square surface {1}", cubeSize, cubeSquare);
        }
    }
}
