using System;

namespace _158B_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           // int[] task = new int[n];
            int countTaxi = 0, c3 =0, c2=0, c1 =0;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                if (mass[i] == "4")
                {
                    countTaxi ++;
                }
                else if (mass[i] == "3")
                {
                    c3 ++;
                }
                else if (mass[i] == "2")
                {
                    c2 ++;
                }
                else
                {
                    c1 ++;
                }
            }

            if (c3 >= c1)
            {
                countTaxi+= c1 + (c3 - c1);
                c1 = 0;
                c3 = 0;
            }
            else 
            {
                countTaxi += c3;
                c1 = c1 - c3;
            }

            if(c2 != 0)
            {
                countTaxi += (c2 / 2);
                c2 = c2 - (c2 / 2)*2;
            }

            if(c2==0 & c1 == 0)
            {
                Console.WriteLine(countTaxi);
                return;
            }
            else if (c2 != 0 & c1 == 0)
            {
                countTaxi++;
            }
            else 
            {
                int d = c1 / 4;
                int m = c1 % 4;

                if(m<3 & m > 0)
                {
                    countTaxi += d + 1;
                }
                else
                {
                    countTaxi += c2 + d + (m/2);
                }
                
            }

            Console.WriteLine(countTaxi);
        }
    }
}
