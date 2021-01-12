using System;
using System.Linq;

namespace _977A_Tanya
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            for(int i = 1; i <= mass[1]; i++)
            {
                if(mass[0] % 10 == 0)
                {
                    mass[0] /= 10;
                }
                else
                {
                    mass[0] -= 1; 
                }

            }

            Console.WriteLine(mass[0]);
        }
    }
}
