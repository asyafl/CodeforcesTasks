using System;

namespace _467A_Yurii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] task = new int[n, 2];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = i; j < n; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        task[j, k] = int.Parse(mass[k]);

                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                if (task[i, 1] - task[i, 0] >=2)
                {
                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
}
