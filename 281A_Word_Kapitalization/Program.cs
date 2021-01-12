using System;

namespace _281A_Word_Kapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(str.Substring(0, 1).ToUpper() + str.Substring(1));
        }
    }
}
