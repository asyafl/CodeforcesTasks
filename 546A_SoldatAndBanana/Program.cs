using System;

namespace _546A_SoldatAndBanana
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, w, banana=0;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            k = int.Parse(mass[0]);
            n = int.Parse(mass[1]);
            w = int.Parse(mass[2]);

            for (int i =1; i <= w; i++)
            {
                banana = banana+ k * i;
            }

            if (n >= banana)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(banana - n);
            }

        }
    }
}
