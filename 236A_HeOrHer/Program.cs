using System;
using System.Linq;

namespace _236A_HeOrHer
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] unique = str.Distinct().ToArray();

            if (unique.Length % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }
           
        }
    }
}
