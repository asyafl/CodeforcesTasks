using System;
using System.Linq;

namespace _581A_Hipster
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int maxS = Math.Min(mass[0], mass[1]);
            int socks = (Math.Max(mass[0], mass[1]) - maxS) / 2;

            Console.WriteLine("{0} {1}", maxS, socks);
        }
    }
}
