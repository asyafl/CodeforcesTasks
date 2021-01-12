using System;
using System.Linq;

namespace _405A_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var mass = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .OrderBy(x => x)
              .ToArray();

            foreach(int i in mass)
            {
                Console.Write("{0} ", i);
            }
           
        }
    }
}
