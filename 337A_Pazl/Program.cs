using System;
using System.Linq;

namespace _337A_Pazl
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var mass1 = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => int.Parse(x))
              .ToArray();

            var mass = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .OrderBy(x => x)
               .ToArray();

            int maxDif = int.MaxValue , temp=0;

            for(int i = 0, j=mass1[0]-1; i < mass.Length && j< mass.Length; i++, j++)
            {
                temp = mass[j] - mass[i];

                if(maxDif >= temp)
                {
                    maxDif = temp;
                }

            }

            Console.WriteLine(maxDif);

        }
    }
}
