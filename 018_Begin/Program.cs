using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int point_A = 23;
            int point_B = 26;
            int point_C = 35;

            int line_AC = Math.Abs(point_A - point_C);
            int line_BC = Math.Abs(point_B - point_C);

            int linesMultiplication = line_AC * line_BC;

            Console.WriteLine("The result is {0}",linesMultiplication);
        }
    }
}
