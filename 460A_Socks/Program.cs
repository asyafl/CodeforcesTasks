using System;
using System.Linq;

namespace _460A_Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int days = 0, socks = mass[0];

            do
            {
               socks--;
               days++;

                if (days % mass[1] == 0 && days != 0)
                {
                    socks++;
                }
            }
            while (socks != 0);

            Console.WriteLine(days);
        }
    }
}
