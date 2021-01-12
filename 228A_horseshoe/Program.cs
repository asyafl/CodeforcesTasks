using System;
using System.Linq;

namespace _228A_horseshoe
{
    class Program
    {
        static void Main(string[] args)
        {

            var mass = Console.ReadLine()
            .Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray()
            .Distinct();

            Console.WriteLine(4 - mass.Count());
        }
    }
    
}
