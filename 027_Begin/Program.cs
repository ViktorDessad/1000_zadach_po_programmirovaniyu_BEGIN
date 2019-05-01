using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            res = (int)Math.Pow(number, 2);
            Console.WriteLine("The result is: {0}", res);
            
            res = (int)Math.Pow(number, 4);
            Console.WriteLine("The result is: {0}", res);

            res = (int)Math.Pow(number, 6);
            Console.WriteLine("The result is: {0}", res);

        }

        
    }
}
