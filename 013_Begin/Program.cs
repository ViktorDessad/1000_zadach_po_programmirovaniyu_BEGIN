using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRadius = 16;
            int secondRadius = 10;

            double firstSquare = Math.PI * Math.Pow(firstRadius,2);
            double secondSquare = Math.PI * Math.Pow(secondRadius, 2);

            double thirdSquare = firstSquare - secondSquare;

            Console.WriteLine("Third square size is {0:#.##}", thirdSquare);
        }
    }
}
