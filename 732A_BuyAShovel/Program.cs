using System;
using System.Linq;

namespace _732A_BuyAShovel
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            for(int i = 1; i <= 10; i++)
            {
                int temp = (mass[0] * i) % 10;

                if (temp == 0 || temp == mass[1])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
