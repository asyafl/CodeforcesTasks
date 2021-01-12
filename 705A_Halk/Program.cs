using System;

namespace _705A_Halk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            System.Text.StringBuilder str = new System.Text.StringBuilder("I hate ");

            if (n == 1)
            {
                str.Append("it");
            }
            else
            {
                str.Append("that");

                for (int i = 2; i <= n; i++)
                {
                    if (i == n)
                    {
                        if (n % 2 == 0)
                        {
                            str.Append(" I love it");
                        }
                        else
                        {
                            str.Append(" I hate it");
                        }
                    } 
                    else if (i % 2 == 0 && i != n)
                    {
                        str.Append(" I love that");
                    }
                    else
                    {
                        str.Append(" I hate that");
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
