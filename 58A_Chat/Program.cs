using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _58A_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var p = @".*h.*e.*l.*l.*o.*";
            Regex regex = new Regex(p);
            MatchCollection matches = regex.Matches(str);
            var t = new List<HashSet<string>>();
            if (matches.Count>0)
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
