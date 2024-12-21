using LabWork10;
using System;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner;

            do
            {
                Console.WriteLine("Введите количество градусов: ");
                int gradus = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество минут");
                int min = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество секунд");
                int sec = int.Parse(Console.ReadLine());

                corner = new Corner(gradus, min, sec);
            }
            while (corner.isCorrect == false);

            double radians = corner.ToRadians();

            Console.WriteLine(radians);
            Console.ReadKey();
        }
    }
}
