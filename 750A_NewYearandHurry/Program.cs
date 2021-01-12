using System;
using System.Linq;

namespace _750A_NewYearandHurry
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int temp = 0 , count = 0; 
            int timeV =  mass[1] + 1200; 

            if(timeV <= 0)
            {
                Console.WriteLine(count);
                return;
            }

            for(int i = 1; i <= mass[0]; i++)
            {
                temp += 5 * i;

                if(timeV + temp <= 1440)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
           
        }
    }
}
