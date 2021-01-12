using System;

namespace A50_Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, res;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(mass[0]); 
            m = int.Parse(mass[1]); 

            res = (n*m) / 2;
            Console.WriteLine(res);
        }
    }
}
