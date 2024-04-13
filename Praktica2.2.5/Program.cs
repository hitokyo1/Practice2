using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        NamesSurname people = new NamesSurname();
        while (true)
        {
            Console.WriteLine("Введите число 0, чтобы завершить работу программы.");
            Console.WriteLine("Введите число 1, чтобы ввести имя и фамилию");
            Console.WriteLine("Введите число 2, чтобы показать данные");
            Console.Write("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.Write("Введите Имя: ");
                    String name1 = Console.ReadLine();
                    Console.Write("Введите Фамилию: ");
                    String name2 = Console.ReadLine();
                    people = new NamesSurname(name1, name2);
                    break;
                case 2:
                    Console.WriteLine(people.name);
                    Console.Write(people.surname);
                    break;   
            }
        }
    }
}