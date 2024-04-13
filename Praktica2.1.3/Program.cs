using System;

namespace Praktica2._1._3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите длину массива: ");
            int len = Int32.Parse(Console.ReadLine());
            int[] nums = new int[len];
            
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Int32.Parse(Console.ReadLine());
            }
             
            bool a = false;
            
            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])   
                {
                    a = true;
                }
            }
            
            Console.WriteLine(a);
        }
    }
}