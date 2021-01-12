using System;

namespace _268A_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] home = new int[n];
            int[] outs = new int[n];

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                    home[i] = int.Parse(mass[0]);
                    outs[i] = int.Parse(mass[1]);

            }

            int res = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(i != j && home[i] == outs[j])
                    {
                        res++;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
