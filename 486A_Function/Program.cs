using System;

namespace _486A_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            double func = 0;

         if( n % 2 == 0)
                {
                    func =  (n + 1) / 2;
                }
         else
                {
                    func += Math.Floor((-n) / 2.0);
                }

            Console.WriteLine(func);
        }
    }
}
