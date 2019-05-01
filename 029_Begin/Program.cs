using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение в градусах от 0 до 360");
            Console.Write("Число: ");

            int number = Convert.ToInt32(Console.ReadLine());

            double RadianInOneDegree = Math.PI / 180; 

            if (number>0 && number<360)
            {
                double res = number * RadianInOneDegree;
                Console.WriteLine("Результат: {0} rad", res);
            }
            else
            {
                Console.WriteLine("Число должно быть больше 0 и меньше 360");
            }
        }
    }
}
