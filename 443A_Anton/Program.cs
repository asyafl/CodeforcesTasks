using System;
using System.Linq;

namespace _443A_Anton
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ',', ' ', '}', '{' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray()
            .Distinct();

            Console.WriteLine(mass.Count());
        }
    }
}
