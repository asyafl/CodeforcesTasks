using System;
using System.Linq;

namespace _723A_NewYearAndFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int avr = mass.Sum() / 3;
            int temp = int.MaxValue, pos = 0, res = 0; ;

            if(mass.Any(x => x == avr))
            {
                res = Math.Abs(mass[0] - avr) + Math.Abs(mass[1] - avr) + Math.Abs(mass[2] - avr);
                Console.WriteLine(res);
            }
            else
            {
                for(int i = 0; i< 3; i++)
                {
                    int diff = Math.Abs(mass[i] - avr);

                    if(temp >= diff)
                    {
                        temp = diff;
                        pos = i;
                    }
                }
                res = Math.Abs(mass[0] - mass[pos]) + Math.Abs(mass[1] - mass[pos]) + Math.Abs(mass[2] - mass[pos]);

                Console.WriteLine(res);
            }
            
        }
    }
}
