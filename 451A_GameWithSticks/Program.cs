using System;
using System.Linq;

namespace _451A_GameWithSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int temp = 0;
            int intersection = mass[0] * mass[1];

            do
            {
                mass[0]--;
                mass[1]--;

                intersection = mass[0] * mass[1];
                temp++;
            }
            while (intersection > 0);

            Console.WriteLine(temp % 2 == 0 ? "Malvika" : "Akshat");
        }
    }
}
