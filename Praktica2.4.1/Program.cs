using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int answer = 0;
        List<int> num = new List<int>();
        Console.Write("Введите римское число: ");
        string romeNum = Console.ReadLine();
        for (int i = 0; i < romeNum.Length; i++)
        {

            switch (romeNum[i])
            {

                case 'I':
                    num.Add(1);
                    break;
                case 'V':
                    num.Add(5);
                    break;
                case 'X':
                    num.Add(10);
                    break;
                case 'L':
                    num.Add(50);
                    break;
                case 'C':
                    num.Add(100);
                    break;
                case 'D':
                    num.Add(500);
                    break;
                case 'M':
                    num.Add(1000);
                    break;
            }
        }

        for (int i = 0; i < romeNum.Length - 1; i++)
        {
            if (num[i] < num[i + 1])
            {
                num[i] = num[i] * (0 - 1);
            }
        }

        for (int i = 0; i < romeNum.Length; i++)
        {
            answer = answer + num[i];
        }
        Console.WriteLine($"Преобразованное число: {answer}");
    }
}