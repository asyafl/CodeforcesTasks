using System;
using System.Linq;

namespace _469A_IWannaBetheGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Where((val, idx) => idx != 0)
            .ToArray();

            var mass1 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Where((val, idx) => idx != 0)
            .ToArray();


            int[] resMass = new int[mass.Length + mass1.Length];
            mass.CopyTo(resMass, 0);
            mass1.CopyTo(resMass, mass.Length);

            if (resMass.Distinct().Count() == n)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
            
        }
    }
}
