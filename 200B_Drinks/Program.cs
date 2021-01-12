using System;
using System.Linq;

namespace _200B_Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => double.Parse(x) / 100)
            .ToArray();

            double res =( mass.Sum() / n) * 100.0;
            Console.WriteLine("{0:N12}",res);
        }
    }
}
