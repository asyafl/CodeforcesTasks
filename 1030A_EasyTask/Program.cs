using System;
using System.Linq;

namespace _1030A_EasyTask
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

            for (int i = 0; i < mass.Length; i++)
            { 
                if(mass[i] == 1)
                {
                    Console.WriteLine("HARD");
                    return;
                }
            }
            Console.WriteLine("EASY");
        }
    }
}
