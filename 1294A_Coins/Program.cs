using System;
using System.Linq;

namespace _1294A_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] nums = new int[n,4];

            for (int i = 0; i<n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < 4; j++)
                {
                    nums[i,j]= int.Parse(mass[j]);
                }
                   
            }

            for (int i = 0; i < n; i++)
            {

               int maxV = Math.Max(Math.Max(nums[i,0], nums[i,1]), nums[i,2]);
               int minV = Math.Min(Math.Min(nums[i,0], nums[i,1]), nums[i,2]);
               int mV = nums[i,0] + nums[i,1] + nums[i,2] - maxV - minV;

                int temp = nums[i, 3] - ((maxV - mV) + (maxV - minV));

                if((temp % 3 == 0 && temp >0)|| temp == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

    }

        }
    }
}
