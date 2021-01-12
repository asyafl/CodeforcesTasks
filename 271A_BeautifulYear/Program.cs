using System;
using System.Linq;

namespace _271A_BeautifulYear
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(str);
            
            do
            {
                n += 1;
                str = n.ToString();

                if(str.Distinct().Count() == 4)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    break;
                }
            }
            while (true);
        }
    }
}
