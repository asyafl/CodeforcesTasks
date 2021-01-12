using System;
using System.Linq;

namespace _266B_turn
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string str = Console.ReadLine();

            for (int i=0;i<mass[0]; i++)
            {
               str = str.Replace("BG","GB");
            }
            Console.WriteLine(str);
        }
    }
}
