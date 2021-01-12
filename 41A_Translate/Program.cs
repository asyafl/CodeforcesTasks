using System;

namespace _41A_Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            
            for(int i=0, j=str2.Length-1; i<str1.Length && j >= 0; i++, j--)
            {
                if (!str1[i].Equals(str2[j]))
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
