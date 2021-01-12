using System;

namespace _479A_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int res, res1, res2, res3;

            res1 = (a + b) * c;
            res2 = a * (b + c);
            res3 = a * b * c;
            res = a + b + c;

            int mV = Math.Max(res1, res2);
            int mV1 = Math.Max(res3, res);


            Console.WriteLine(Math.Max(mV,mV1));
        }
    }
}
