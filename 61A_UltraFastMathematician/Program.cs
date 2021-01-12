using System;

namespace _61A_UltraFastMathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            System.Text.StringBuilder strNew = new System.Text.StringBuilder();
            for (int i =0; i < str1.Length; i++)
            {
                if (str1[i].Equals(str2[i]))
                {
                    strNew.Append('0');
                }
                else
                {
                    strNew.Append('1');
                }
            }
            Console.WriteLine(strNew);
        }
    }
}
