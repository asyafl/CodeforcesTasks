using System;
using System.Linq;

namespace _466A_CheapTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();


            int proszn;

            if (mass[0] <= mass[1])
            {
                proszn = mass[0] / mass[1];
            }
            else
            {
                int temp = mass[0] / mass[1];

            }
            Console.WriteLine("Hello World!");
        }
    }
}
