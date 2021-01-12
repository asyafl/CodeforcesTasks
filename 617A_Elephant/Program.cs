using System;

namespace _617A_Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0, temp;

            for(int i =5; i>0 && n!=0;i--)
            {
                temp = n / i;
                n %= i;
                count += temp;
            }
            Console.WriteLine(count);
        }
    }
}
