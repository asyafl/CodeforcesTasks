using System;
using System.Linq;

namespace _160A_Twins
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int[] task = new int[n];
            int count = 0, sumTw =0, sum=0;
            var mass = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .ToArray();

             sum = task.Sum();
            
            for (int i = n-1; i >=0; i--)
            {
                if (sumTw <= sum)
                {
                    sumTw += task[i];
                    sum -= task[i];
                    count++;
                }
                else
                    break;
            }
            
                Console.WriteLine(count);
            

        }
    }
}
