using System;
using System.Collections.Generic;

namespace Praktica2._1._2
{
    class Program
    {
        static void Main()
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 }; 
            int target = 8; 
            Array.Sort(candidates); 
            var result = new List<List<int>>(); 
            var list = new List<(int, int, List<int>)>(); 
            list.Add((0, target, new List<int>())); 
         
            int index = 0; 
            while (index < list.Count) 
            { 
                var (start, remainingTarget, current) = list[index]; 
 
                if (remainingTarget == 0) 
                { 
                    result.Add(new List<int>(current)); 
                } 
 
                for (int i = start; i < candidates.Length && candidates[i] <= remainingTarget; i++) 
                { 
                    if (i > start && candidates[i] == candidates[i - 1]) 
                    { 
                        continue; 
                    } 
 
                    var newCurrent = new List<int>(current); 
                    newCurrent.Add(candidates[i]); 
                    list.Add((i + 1, remainingTarget - candidates[i], newCurrent)); 
                } 
 
                index++; 
            } 
 
            foreach (var combination in result) 
            { 
                Console.WriteLine(string.Join(", ", combination)); 
            } 
        }
    }
}