using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Begin
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите скорость первого автомобиля в км/час: ");
            double firstAutoSpeed = Convert.ToDouble(Console.ReadLine());
            double firstAutoSpeedInMinutes = firstAutoSpeed / 60;
     
            Console.Write("Введите время нахождения первого автомобиля в пути в часах: ");
            double firstAutoTime = Convert.ToDouble(Console.ReadLine());
            double firstAutoTimeInMinutes = firstAutoTime * 60;

            double firstAutoFullDistance = firstAutoSpeedInMinutes * firstAutoTimeInMinutes;

            Console.Write("Введите скорость второго автомобиля в км/час: ");
            double secondAutoSpeed = Convert.ToDouble(Console.ReadLine());
            double secondAutoSpeedInMinutes = secondAutoSpeed / 60;

            Console.Write("Введите время нахождения второго автомобиля в пути в часах: ");
            double secondAutoTime = Convert.ToDouble(Console.ReadLine());
            double secondAutoTimeInMinutes = secondAutoTime * 60;

            double secondAutoFullDistance = secondAutoSpeedInMinutes * secondAutoTimeInMinutes;

            double distanceBetweenTwoCar = 45.56;
            double fullDistanceBetweenTwoCar = distanceBetweenTwoCar + secondAutoFullDistance + firstAutoFullDistance;
            Console.WriteLine("Общее расстояние {0} km", fullDistanceBetweenTwoCar);











        }
    }
}
