using System;

namespace _116A_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] task = new int[n,2];
            int countP = 0;

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = i; j < n;  j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        task[j, k] = int.Parse(mass[k]);

                    }
                }
               
            }

            int maxVal = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j< 1; j++)
                {
                    countP = countP - task[i, j] + task[i, j + 1];
                    if(countP> maxVal)
                    {
                        maxVal = countP;
                    }
                }
            }

           
              Console.WriteLine(maxVal);
        }
    }
}
