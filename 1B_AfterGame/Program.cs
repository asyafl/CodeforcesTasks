using System;

namespace _1B_AfterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, middle;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(mass[0]); //м*ячі
            m = int.Parse(mass[1]); //корзини
            middle = m / 2;

            int[] nums = new int[m + 1]; //номеруємо корзини від 1 
            for (int i = 0; i < m; i++)
            {
                nums[i] = i + 1;
            }


            double temp = Math.Ceiling(n / (m * 1.0));
            int t = 0, count = 0, bb=0;

            while (t < temp)
            {
                bb = count;
                if (m % 2 == 0)
                {
                     
                    for (int i = 0, k = middle - 1, j = middle; i < middle & count < n; --k, ++j)
                    {
                        
                        if (count+1 < n)
                        {
                            Console.WriteLine(nums[k]);
                            Console.WriteLine(nums[j]);
                        }
                        
                        else
                            Console.WriteLine(nums[k]);

                        i++;
                        count = bb + i * 2 ;
                       // Console.WriteLine("frg: {0}", count);
                    }
                   
                }

                else
                {
                    middle = (m + 1) / 2;

                    for (int i = 0, k = middle - 1, j = middle - 1; i < middle & count < n; --k, ++j)

                    {
                        if (count + 1 < n)
                        {
                            if (j == middle - 1)
                            {
                                Console.WriteLine(nums[k]);
                            }
                            else
                            {
                                Console.WriteLine(nums[k]);
                                Console.WriteLine(nums[j]);
                            }
                        }
                        else
                            Console.WriteLine(nums[k]);
                        i++;
                        count = bb + i*2 -1;
                       // Console.WriteLine("frg: {0}", count);
                    }
                    
                }
                t++;
            }
           // Console.WriteLine(count);
        }
    }
}
