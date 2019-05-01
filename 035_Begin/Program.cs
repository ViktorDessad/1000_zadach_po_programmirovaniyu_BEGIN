using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорось лодки в стоячей воде км/час: ");
            double boatSpeedInDeadWater = Convert.ToDouble(Console.ReadLine());
            double riverSpeed = 5.42;

            if (boatSpeedInDeadWater > riverSpeed)
            {
                Console.Write("Введите время движения по воде стоячей: ");
                double boatTimeInDeadWater = Convert.ToDouble(Console.ReadLine());

                double boatDistanceInDeadWater = (boatSpeedInDeadWater + riverSpeed) * boatTimeInDeadWater;

                Console.Write("Введите время движения по воде против течения: ");
                double boatTimeInUpStream = Convert.ToDouble(Console.ReadLine());

                double boatDistanceInUpStream = (boatSpeedInDeadWater - riverSpeed) * boatTimeInUpStream;

                double fullDistance = boatDistanceInDeadWater + boatDistanceInUpStream;

                Console.WriteLine("" +
                    "Скорость лодки в стоячей воде {0}, " +
                    "время в стоячей воде {1}, " +
                    "время движения по воде против течения {2}, " +
                    "скорость реки {3}, " +
                    "полное расстояние пройденное кораблем {4} ",   
                    boatSpeedInDeadWater, 
                    boatTimeInDeadWater, 
                    boatTimeInUpStream,
                    riverSpeed,
                    fullDistance);

            }
            else
            {
                Console.WriteLine("Скорость корабля должна быть больше течения реки");
            }


        }
    }
}
