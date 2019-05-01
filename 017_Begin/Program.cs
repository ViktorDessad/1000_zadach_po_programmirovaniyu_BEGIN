using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            int point_A = 10;
            int point_B = 12;
            int point_C = 14;

            int line_AC = Math.Abs(point_A - point_C);
            int line_BC = Math.Abs(point_B - point_C);

            int lineSum = line_AC + line_BC;

            Console.WriteLine("Lines sum is {0}", lineSum);
        }
    }
}
