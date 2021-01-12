using System;

namespace _266A_StoneatTheTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int count = 0;

            for (int i =1; i < n; i++)
            {
                if (str[i].Equals(str[i - 1]))
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
            
        }
    }
}
