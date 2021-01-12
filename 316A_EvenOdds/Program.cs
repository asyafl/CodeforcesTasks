using System;
using System.Linq;

namespace _316A_EvenOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => long.Parse(x))
              .ToArray();

            double odd = Math.Ceiling(mass[0] / 2.0);
            double number;

            if(mass[1] <= odd)
            {
                number = (2 * mass[1]) - 1; 
            }
            else
            {
                number = 2 * (mass[1] - odd);

            }
            Console.WriteLine(number);
        }
    }
}
