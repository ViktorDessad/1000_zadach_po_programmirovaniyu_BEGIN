using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение температуры в Фаренгейтах: ");
            double inFahrengait = Convert.ToDouble(Console.ReadLine());

            double inCelsius = ((inFahrengait - 32) * 5) / 9;

            Console.WriteLine("Результат в Цельсиях: {0} C", inCelsius);

        }
    }
}
