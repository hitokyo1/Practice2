using System;  
using System.Collections.Generic;
using System.Text;
using System.Linq;
class Program
{
    static void Main()
    {
        Counter count = new Counter();
        Random rand = new Random();

        while (true)
        {
            Console.WriteLine("Введите число 0, чтобы завершить работу счетсчика.");
            Console.WriteLine("Введите число 1, чтобы уменьшить значение счетчика.");
            Console.WriteLine("Введите число 2, чтобы увеличить значение счетчика.");
            Console.WriteLine("Введите число 3, чтобы вывести значение счетчика.");
            Console.WriteLine("Введите число 4, чтобы счетчик произвольное значение.");
            Console.WriteLine("Введите номер операции: ");
            int num = int.Parse(Console.ReadLine());
            int number = 0;

            switch (num)
            {
                case 0:
                    Console.WriteLine("Вы завершили работу программу.");
                    return;
                case 1:
                    count.shetchickOfLow();
                    break;
                case 2:
                    count.shetchickOfSum();
                    break;
                case 3:
                    Console.WriteLine(count.Output);
                    break;
                case 4:
                    number = rand.Next();
                    count = new Counter(number);
                    break;
            }
        }  
    }
}