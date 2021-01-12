using System;

namespace _112A_LuckyNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] luckyN = new int[] { 4, 7, 44, 47, 77, 74, 444, 447, 477, 474, 744, 747, 777, 774 };

            for(int i =0; i < luckyN.Length; i++)
            {
                if (n % luckyN[i] == 0)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
