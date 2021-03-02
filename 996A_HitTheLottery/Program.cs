using System;

namespace _996A_HitTheLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var l = new Lottery();
            Console.WriteLine(l.Solve(n));
        }
    }

    public class Lottery
    {
        private int[] bills = new int[5] { 100, 20, 10, 5, 1 }; 
        public int Solve(int n)
        {
            int result = 0;

            while (n != 0)
            {
                foreach(var b in bills)
                {
                    int tmp = 0;

                    while ((n - b) >= 0)
                    {
                        n -= b;
                        tmp++;
                    }

                    result += tmp;
                }
            }

            return result;
        }
    }
}
