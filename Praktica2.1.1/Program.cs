using System;

namespace Praktica2._1._1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку J: ");string j = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите строку S: ");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char stone in s)
            {
                if (j.Contains(stone))   
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}