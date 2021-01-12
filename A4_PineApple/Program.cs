using System;

namespace A4_PineApple
{
    class Program
    {
        static void Main(string[] args)
        {
           string n = Console.ReadLine();
            
            if(int.Parse(n) % 2 == 0 & int.Parse(n) != 2)
            {
                Console.WriteLine("YES");
            } 
            else
                Console.WriteLine("NO");
        }
    }
}

