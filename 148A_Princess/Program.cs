using System;
using System.Linq;

namespace _148A_Princess
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int[] dracaris = new int[d];

            for (int i = k-1; i < d; i+=k)
            {
                dracaris[i] = 1;
            }

            for (int i = l-1; i < d; i += l)
            {
                dracaris[i] = 1;
            }

            for (int i = m-1; i < d; i += m)
            {
                dracaris[i] = 1;
            }

            for (int i = n-1; i < d; i += n)
            {
                dracaris[i] = 1;
            }

            Console.WriteLine(dracaris.Sum());
        }
    }
}
