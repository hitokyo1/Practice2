using System;  
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        Workers people = new Workers();

        while (true)
        {
            Console.WriteLine("\nНажмите на 0, чтобы завершить работу программы.");
            Console.WriteLine("Нажмите 1, чтобы ввести данные о рабочем.");
            Console.WriteLine("Нажмите 2, чтобы ввести ставку за один рабочий день.");
            Console.WriteLine("Нажмите 3, чтобы ввести кол-во отработанных дней.");
            Console.WriteLine("Нажмите 4, чтобы вывести информацию о рабочем.");
            Console.WriteLine("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.Write("Вы завершили программу.");
                    return;
                case 1:
                    Console.Write("Введите имя рабочего: ");
                    people.Name = Console.ReadLine();
                    Console.Write("Введите фамилию рабочего: ");
                    people.Surname = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введите ставку за один рабочий день: ");
                    people.Rate = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Введите кол-во отработанных дней: ");
                    people.Days = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine($"Имя и фамилия: {people.Name} {people.Surname}");
                    Console.WriteLine($"Ставка: {people.Rate}");
                    Console.WriteLine($"Отработанно: {people.Days} дня(дней)");
                    Console.WriteLine($"Зарплата: {people.GetSalary()} руб.");
                    break;
            }
        }
    }
}