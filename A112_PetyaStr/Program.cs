using System;

namespace A112_PetyaStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            Console.WriteLine(String.Compare(str1, str2));
        }
    }
}
