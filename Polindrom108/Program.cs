using System;

namespace Polindrom108
{
    class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
           str = str.ToLower();
           double l = str.Length / 2.0;

            string str1 = str.Substring(0, str.Length / 2);
            string str2 = str.Substring((int)Math.Ceiling(l), str.Length  - (int) Math.Ceiling(l));
            char[] sRev = str2.ToCharArray();
            Array.Reverse(sRev);
            str2 = new string(sRev);

            if (string.Compare(str1, str2) == 0)
                {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
            

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
