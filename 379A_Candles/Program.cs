using System;
using System.Linq;

namespace _379A_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int hours = 0, candles = mass[0];

            do
            {
                candles--;
                hours++;

                if (hours % mass[1] == 0 && hours != 0)
                {
                    candles++;
                }
            }
            while (candles != 0);

            Console.WriteLine(hours);
        }
    }
}
