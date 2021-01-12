using System;
using System.Linq;

namespace _500A_NewYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            var num = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

          int trip = 1; 

            for(int i = 0; i < num.Length; i+= num[i])
            {
                trip = num[i] + i + 1;

                if ( mass[1] == i + 1 || trip == mass[1])
                {
                    Console.WriteLine("YES");
                    return;
                }
                else if (mass[1] < i + 1)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
