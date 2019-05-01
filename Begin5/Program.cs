using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin5
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSize = 2;
            int secondSize = 3;
            int thirdSize = 4;

            int parallelepipedSize = firstSize * secondSize * thirdSize;
            int surfaceSquare = 2 * (firstSize * secondSize + secondSize * thirdSize + firstSize + thirdSize);

            Console.WriteLine("The result is Size {0}, Square {1}", parallelepipedSize,surfaceSquare);
        }
    }
}
