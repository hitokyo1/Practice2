using System;

namespace Praktica2._2._2
{
    class Program
    {
        static void Main()
        {
            Train train1 = new Train();

            train1.points = "Москва";
            train1.number = 156;
            train1.time = "12:00";

            Train train2 = new Train();

            train2.points = "Томск";
            train2.number = 503;
            train2.time = "18:00";

            Train train3 = new Train();

            train3.points = "Сочи";
            train3.number = 101;
            train3.time = "22:00";

            Train trains = new Train();

            Console.Write("Введите номер поезда, чтобы узнать о нем информацию: ");
            trains.number = int.Parse(Console.ReadLine());

            switch (trains.number)
            {
                case 156:
                    Console.Write($"Поезд под номером {train1.number} отправляется в {train1.points} в {train1.time}");
                    break;
                case 503:
                    Console.Write($"Поезд под номером {train2.number} отправляется в {train2.points} в {train2.time}");
                    break;
                case 101:
                    Console.Write($"Поезд под номером {train3.number} отправляется в {train3.points} в {train3.time}");
                    break;
            }
        }
    }
}