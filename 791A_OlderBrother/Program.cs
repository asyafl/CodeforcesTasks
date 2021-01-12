using System;
using System.Linq;

namespace _791A_OlderBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();
            int count = 0;
            do
            {
                mass[0] *= 3;
                mass[1] *= 2;
                count++;
            }
            while (mass[0] <= mass[1]);

            Console.WriteLine(count);
        }
    }
}
