using System;

namespace A231_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] task = new int[n];
            int count = 0; 

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                task[i] = int.Parse(mass[0]) + int.Parse(mass[1]) + int.Parse(mass[2]);
            }

            for (int i =0; i<n; i++)
            {
                if (task[i] > 1)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
