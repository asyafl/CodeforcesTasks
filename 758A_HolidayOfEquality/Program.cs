using System;
using System.Linq;

namespace _758A_HolidayOfEquality
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

            Array.Sort(mass);

            int res = Math.Abs(mass.Sum() - (mass[n - 1] * n));

            Console.WriteLine(res);
        }
    }
}
