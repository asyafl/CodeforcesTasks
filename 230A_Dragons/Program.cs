using System;
using System.Collections.Generic;
using System.Linq;

namespace _230A_Dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int s = int.Parse(mass[0]);
            int n = int.Parse(mass[1]);


            int[][] dragons = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var mass1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                dragons[i] = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    dragons[i][j] = int.Parse(mass1[j]);
                }
            }
         
            int[][] dragonsSort = dragons.OrderBy(x => x[0]).ToArray(); 


            for(int i = 0; i < n; i++)
            {
                if(s > dragonsSort[i][0])
                {
                    s += dragonsSort[i][1];
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
