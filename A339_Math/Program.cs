using System;

namespace A339_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var mass = Console.ReadLine().Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
            int[] test = new int[mass.Length];
            Array.Sort(mass);

            for (int i = 0; i < mass.Length; i++)
            {
                if(i == 0)
                {
                    Console.Write("{0}", mass[i]);
                }
                else
                Console.Write("+{0}",mass[i]);
            }
              
        }
    }
}
