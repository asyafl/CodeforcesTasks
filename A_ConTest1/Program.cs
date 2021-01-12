using System;

namespace A_ConTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] task = new int[n, 2];
            double optimDay = 0;

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = i; j < n; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        task[j, k] = int.Parse(mass[k]);

                    }
                }
            }

            for(int i =0; i < n; i++)
            {
                
                double incr = task[i, 1], temp=double.MaxValue;

                for(int x = 1;x< task[i,0];x++)
                {
                    optimDay = Math.Ceiling(task[i, 1] / (1+x*1.0));
                    temp = x + optimDay;

                    if (temp<= task[i, 0])
                    {
                       
                        break;
                    }
                    else
                    {
                        incr = temp;
                    }

                }
                if (temp <= task[i, 0] || task[i, 0] == task[i, 1])
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
