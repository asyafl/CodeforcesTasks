using System;
using System.Linq;

namespace _492B_VanyaAndLanterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(mass[0]);
            int l = int.Parse(mass[1]);

            var lanterns = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(x => int.Parse(x))
           .OrderBy(x => x)
           .ToArray();

            int maxV = int.MinValue , temp;

            for(int i = 1; i < lanterns.Length; i++)
            {
                temp = lanterns[i] - lanterns[i - 1];
                if(temp > maxV)
                {
                    maxV = temp;
                }
            }

            if(lanterns.Length == 1)
            {
                if(lanterns[0] > (l - lanterns[0]))
                {
                    Console.WriteLine("{0:F10}", lanterns[0]);
                }
                else
                {
                    Console.WriteLine("{0:F10}", (l - lanterns[0]));
                }
                
            }   
            else if ((lanterns[0] != 0 && (maxV / 2.0) < lanterns[0]) 
                  || (l - lanterns[lanterns.Length-1] > (maxV / 2.0)))
            {
                if (lanterns[0] > (l - lanterns[lanterns.Length - 1]))
                {
                   Console.WriteLine("{0:F10}", lanterns[0]);
                }
                else
                {
                    Console.WriteLine("{0:F10}", (l - lanterns[lanterns.Length - 1]));
                }
            }
            else
            {  
                Console.WriteLine("{0:F10}", (maxV / 2.0));
            }
        }
    }
}
