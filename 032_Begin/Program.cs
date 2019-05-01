using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение в Цельсиях: ");
            double inCelsius = Convert.ToDouble(Console.ReadLine());

            double inFahrengait = ((17.78 + inCelsius) * 9) / 5;

            Console.WriteLine("Результат: {0} F", inFahrengait);


        }
    }
}
