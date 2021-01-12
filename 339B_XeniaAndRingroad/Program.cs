using System;
using System.Linq;

namespace _339B_XeniaAndRingroad
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(mass[0]);
            int m = int.Parse(mass[1]);

            var affairs = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(x => int.Parse(x))
           .ToArray();

           long step = affairs[0] - 1;

            for(int i=1; i < m; i++)
            {
                if (affairs[i] < affairs[i - 1])
                {
                    step += (n - affairs[i-1]) + affairs[i];
                }
                else if (affairs[i] > affairs[i - 1])
                {
                  step += (affairs[i] - affairs[i - 1]);
               
                }
            }
            Console.WriteLine(step);
        }
    }
}
