using System;   
using System.Collections.Generic;
using System.Text;
using System.Linq;
class Program
{
    static void Main()
    {
        Numbers number = new Numbers(0, 0);
        while (true)
        {
            Console.WriteLine("Введите число 0 чтобы закончить программу.");
            Console.WriteLine("Введите число 1 чтобы измеить числа");
            Console.WriteLine("Введите число 2 чтобы вывести числа");
            Console.WriteLine("Введите число 3 чтобы найти сумму чисел");
            Console.WriteLine("Введите число 4 чтобы найти максимальное число");
            int chislo = int.Parse(Console.ReadLine());
            switch (chislo)
            {
                case 0:
                    Console.WriteLine("Программа завершена");
                    return;
                case 1:
                    Console.Write("Введите Перове число: ");
                    int nums1 = int.Parse(Console.ReadLine());
                    Console.Write("Введите Второе число: ");
                    int nums2 = int.Parse(Console.ReadLine());
                    number.changOfNumbers(nums1, nums2);
                    break;
                case 2:
                    number.conclusionOfNumbers();
                    break;
                case 3:
                    Console.WriteLine($"Сумма чисел: {number.sumOfNumbers()}");
                    break;
                case 4:
                    Console.WriteLine($"Наибольшее число: {number.maxOfNumbers()}");
                    break;
            }
        }   
    }
}