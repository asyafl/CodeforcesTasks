using System;
using System.Linq;

namespace _1294B_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][,] nums = new int[n][,];

            for (int i =0; i<n; i++)
            {
                int t = int.Parse(Console.ReadLine());
                for (int k = 0; k < t; i++)
                {
                    var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < 2; j++)
                    {
                        nums[i][k, j] = int.Parse(mass[j]);
                    }
                }
            }

            Array.Sort(nums);

            for(int i = 0; i <5; i++)
            {
                for(int j =0; j <2; j++)
                {
                    Console.WriteLine(nums[0][i, j]);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
