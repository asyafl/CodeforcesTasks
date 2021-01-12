using System;
using System.Linq;

namespace _580A_KefaAndFirstStep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var mass = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();

            int count=0, temp=1;

            for(int i=1; i<n; i++)
            {
               
                if (mass[i] >= mass[i - 1])
                {
                    temp++;
                }
                else
                {
                    if (temp >=count)
                    {
                        count = temp;
                    }
                    temp = 1; 
                }
            }
            Console.WriteLine(count<temp?temp:count);
        }
    }
}
