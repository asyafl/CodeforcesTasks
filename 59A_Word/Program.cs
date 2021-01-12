using System;

namespace _59A_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int countSmall = 0, countB =0;

            for (int i=0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    countB++;
                }
                else
                {
                    countSmall++;
                }
            }

            if (countB > countSmall)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                Console.WriteLine(str.ToLower());
            }
            
        }
    }
}
