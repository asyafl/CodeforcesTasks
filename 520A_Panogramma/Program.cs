using System;
using System.Linq;

namespace _520A_Panogramma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mass = Console.ReadLine().ToUpper().Distinct();

           Console.WriteLine(mass.Count()==26 ? "YES" : "NO");
        }
    }
}
