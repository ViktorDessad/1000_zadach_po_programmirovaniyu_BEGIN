using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение в радианах от 0 до 2 * 3.14");
            Console.Write("Радиан: ");

            int number = Convert.ToInt32(Console.ReadLine());

            double oneRadianInDegree = 180 / Math.PI;

            if (number > 0 && number < (2 * 3.14))
            {
                double res = number * oneRadianInDegree;
                Console.WriteLine("Результат: {0} degree", res);
            }
            else
            {
                Console.WriteLine("Число должно быть больше 0 и меньше 2 * 3.14");
            }
        }
    }
}
