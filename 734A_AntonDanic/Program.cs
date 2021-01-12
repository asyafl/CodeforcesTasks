using System;
using System.Text.RegularExpressions;

namespace _734A_AntonDanic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            var a = @"A";
            var d = @"D";
            Regex regex = new Regex(a);
            Regex regex1 = new Regex(d);

            MatchCollection matchesA = regex.Matches(str);

            MatchCollection matchesD = regex1.Matches(str);

            if (matchesA.Count > matchesD.Count)
            {
                Console.WriteLine("Anton");
            }
            else if (matchesA.Count < matchesD.Count)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
            
        }
    }
}
