using System;

namespace _208A_Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

           str = str.Replace("WUB", " ").Trim().Replace("  ", " ");
           
            Console.WriteLine(str);
        }
    }
}
