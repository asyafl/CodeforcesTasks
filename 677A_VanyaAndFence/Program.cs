using System;
using System.Linq;

namespace _677A_VanyaAndFence
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
               .ToArray();

            int count = 0;

            for(int i = 0; i < mass1[0]; i++)
            {
                if(mass[i] > mass1[1])
                {
                    count += 2;
                }
                else
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
