using System;

namespace _510A_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(mass[0]);
            int m = int.Parse(mass[1]);

            int c = 0;

            for (int i = 0; i < n; i ++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }
                else
                {
                    c++;
                    if (c % 2 != 0)
                    {
                        for (int j = 0; j < m-1; j++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("#\n");
                    }
                    else
                    {
                        Console.Write("#");
                        for (int j = 1; j < m; j++)
                        {
                            Console.Write(".");
                        }
                        Console.Write("\n");
                    }
                    
                }
                
            }
          
        }
    }
}
