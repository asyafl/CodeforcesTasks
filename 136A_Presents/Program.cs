using System;
using System.Linq;

namespace _136A_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var mass = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();

            int[] temp = new int[mass.Length];

            for(int i = 0; i < mass.Length; i++)
            {
                temp[mass[i]-1]=i+1;
            }

            foreach(int t in temp)
            {
                Console.Write("{0} ",t);
            }
        }
    }
}
