using System;

namespace A158_NextRaund
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(mass[0]); //к-ть учасників
            k = int.Parse(mass[1]); //місце
            int temp = k;

           var mass1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mass2 = new int[mass1.Length];

            for (int i= 0; i < mass1.Length; i++)
            {
                mass2[i] = int.Parse(mass1[i]);
            }

            if (mass2[k-1] == 0)
            {
                temp = 0;
                for (int i = 0; i < k-1; i++)
                {
                    if (mass2[i] >= mass2[i + 1] & mass2[i] != 0)
                    {
                        temp += 1;
                    }
                    else
                        break;
                }
            }

            else
            {
                for (int i = k; i < n; i++)
                {
                    if (mass2[i] >= mass2[i - 1] && mass2[i] != 0)
                    {
                        temp += 1;
                    }
                    else
                        break;
                }
            }

            Console.WriteLine(temp);
        }
    }
}
