using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int A1, A2, B1, B2, C1, C2;
            A1 = 2;
            A2 = 3;
            B1 = 4;
            B2 = 5;
            C1 = 6;
            C2 = 7;

            double D = A1 * B2 - A2 * B1;

            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;

            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }
}
