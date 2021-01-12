using System;

namespace A282_Bitt
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] mass = new string[int.Parse(n)];

            for (int i = 0; i < int.Parse(n); i++)
            {

                mass[i] = Console.ReadLine();

            }
            int res = 0;
            for (int i=0; i< int.Parse(n); i++)
            {
                if (mass[i].Contains("++"))
                {
                    res += 1;
                }
                else
                    res -= 1;
            }

            Console.WriteLine(res);
        }
    }
}
