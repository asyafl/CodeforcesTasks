using System;
using System.Linq;

namespace _144A__ArrivalOfTheGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int minV = int.MaxValue;
            int maxV = int.MinValue;
            int maxPos = 1, minPos = 1;
            
            for(int i = 0; i < n; i++)
            {
                if(mass[i] > maxV)
                {
                    maxV = mass[i];
                    maxPos = i;
                }

                if (mass[i] <= minV)
                {
                    minV = mass[i];
                    minPos = i;
                }
            }

            if(maxPos < minPos)
            {
                Console.WriteLine(maxPos + (n - minPos - 1));
            }
            else
            {
                Console.WriteLine(maxPos + (n - minPos - 2));
            }
            
           
        }
    }
}
