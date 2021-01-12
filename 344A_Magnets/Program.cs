using System;

namespace _344A_Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] mass = new string[n];
            int count = 1;

            for(int i =0; i < n; i++)
            {
                mass[i] = Console.ReadLine();
            }

            for (int i = 1; i < n; i++)
            {
                if (!mass[i].Equals(mass[i-1]))
                {
                    count++;
                }
                    
            }

            Console.WriteLine(count);
        }
    }
}
