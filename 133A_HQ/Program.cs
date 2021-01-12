using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _133A_HQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var p = @"(H)|(Q)|(9)";
            Regex regex = new Regex(p);
            MatchCollection matches = regex.Matches(str);
            var t = new List<HashSet<string>>();
            if (matches.Count > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
