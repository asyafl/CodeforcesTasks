using System;

namespace _1295A_DisplaytheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = long.Parse(Console.ReadLine());
            long[] mass = new long[t];
            long[,] num = new long[,] { { 2, 1 },{ 5, 5 }, {3, 7}, {7, 8 } };

            for (long i =0; i < t; i++)
            {
                mass[i] = long.Parse(Console.ReadLine());
            }

            for(long i =0; i<t; i++)
            {
             //   for(long j = 0; j < 4; j++)
             //   {
              if(mass[i] > 59)
              {
                 Console.WriteLine("9999999999");
              }
              else if (mass[i] > 29)
                 {
                    if (mass[i] - 27 > 5)
                    {
                        Console.WriteLine("7777777779");
                    }
                    else if (mass[i] - 27 > 3)
                    {
                        Console.WriteLine("7777777777");
                    }
                    else
                    {
                        Console.WriteLine("7777777771");
                    }
                  }
                else if (mass[i] > 19)
                {
                    if (mass[i] - 18 == 11)
                    {
                        Console.WriteLine("1111117777");
                    }
                    else if (mass[i] - 18 > 9)
                    {
                        Console.WriteLine("1111111777");
                    }
                    else if (mass[i] - 18 > 6)
                    {
                        Console.WriteLine("1111111177");
                    }
                    else if (mass[i] - 18 == 5)
                    {
                        Console.WriteLine("1111111115");
                    }
                    else if (mass[i] - 18 == 4)
                    {
                        Console.WriteLine("1111111114");
                    }
                    else if (mass[i] - 18 == 3)
                    {
                        Console.WriteLine("1111111117");
                    }
                    else
                    {
                        Console.WriteLine("1111111111");
                    }


                }
                else if (mass[i] > 15)
                {
                
                    Console.WriteLine("11111111"); 
                }
                else if (mass[i] > 13)
                {

                    Console.WriteLine("1111111");
                }
                else if (mass[i] > 11)
                {

                    Console.WriteLine("111111");
                }
                else if (mass[i] > 9)
                {

                    Console.WriteLine("11111");
                }
                else if (mass[i] > 8)
                {

                    Console.WriteLine("1111");
                }

            }
              
            
        }
    }
}
