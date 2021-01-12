using System;

namespace _472A_LearnFromMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if(n % 2 == 0)
            {
                Console.WriteLine("{0} {1}", 8 , (n - 8));
            }
            else
            {
                Console.WriteLine("{0} {1}", 9, (n - 9));
            }
           
        }
    }
}
