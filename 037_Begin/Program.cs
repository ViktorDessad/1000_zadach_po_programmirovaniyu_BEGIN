using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время нахождения в пути автомобилей");
            double carTimeOnRoad = Convert.ToDouble(Console.ReadLine());

            if (carTimeOnRoad > 0)
            {
                double firstCarSpeed = 78.34;
                double secondCarSpeed = 89.45;
                double primaryDistance = 1347.56;

                double newDistance = primaryDistance - (firstCarSpeed + secondCarSpeed) * carTimeOnRoad;

                if (newDistance < 0)
                {
                    newDistance = Math.Abs(newDistance);
                    Console.WriteLine("Автомобили разъехались на расстояние в {0} км друг от друга", newDistance);
                }
                else
                {
                    Console.WriteLine("Расстояние между автомобилями равно {0} км", newDistance);
                }
            }
            else
            {
                Console.WriteLine("Время не может быть отрицательным");
            }

            



        }
    }
}
