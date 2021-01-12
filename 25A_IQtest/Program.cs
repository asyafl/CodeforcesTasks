using System;
using System.Linq;

namespace _25A_IQtest
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

            int countT = 0 , count = 0 , cPos = 0, tPos =0;

            for(int i = 0; i< mass.Length; i++)
            {
                if (count > 2 && countT > 2)
                {
                    break;
                }
                else
                {
                    if (mass[i] % 2 == 0)
                    {
                        count++;
                        cPos = i + 1;
                    }
                    else
                    {
                        countT++;
                        tPos = i + 1;
                    }
                }
            }

            Console.WriteLine(countT > count ? cPos : tPos);
        }
    }
}
