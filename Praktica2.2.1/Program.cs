using Praktica2._2._1; 
using System;
class Program
{
        static void Main()
        {
            int studentcount = 0;
            Student[] students = new Student[5];
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("\nВведите число 1, что бы добавить студента");
                Console.WriteLine("Введите число 2, что бы напечатать студента");
                Console.WriteLine("Введите число 0, что бы завершить программу");
                Console.Write("Введите номер операции: ");
                int num = int.Parse(Console.ReadLine()!);
                switch (num)
                {
                    case 0:
                        return;
                    case 1:
                        if (studentcount == 5)
                        {
                            Console.WriteLine("Больше не возможно добавить студентов");
                            break;
                        }
                        Student student = new Student();
                        Console.Write("Введите фамилию и имя студента: ");
                        student.surname = Console.ReadLine()!;
                        Console.Write("Введите дату рождения студента: ");
                        student.dateOfBirthday = Convert.ToDateTime(Console.ReadLine()!);
                        Console.Write("Введите номер группы студента: ");
                        student.numbers = int.Parse(Console.ReadLine()!);
                        for (int i = 0; i < student.marks.Length; i++)
                        {
                            student.marks[i] = rand.Next(2, 5);
                        }
                        students[studentcount] = student;
                        studentcount++;
                        break;
                    case 2:
                        for (int i = 0; i < studentcount; i++)
                        {
                            Console.WriteLine($"Фамилия и имя студента: {students[i].surname}");
                            Console.WriteLine($"Дата рождения: {students[i].dateOfBirthday.ToShortDateString()}");
                            Console.WriteLine($"Номер группы: {students[i].numbers}");
                            Console.WriteLine($"Успеваемость: {string.Join(", ", students[i].marks)}");
                        }
                        break;
                }
            }
        }
}