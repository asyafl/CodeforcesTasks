using System;
using System.Linq;

namespace _155A_IloveUsername
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

            int minV = mass[0], maxV = mass[0], count = 0;

            for(int i=1; i<n; i++)
            {
                if (mass[i] > maxV)
                {
                    count++;
                    maxV = mass[i];
                }
                else if (mass[i] < minV)
                {
                    count++;
                    minV = mass[i];
                }
            }

            Console.WriteLine(count);
        }
    }
}
