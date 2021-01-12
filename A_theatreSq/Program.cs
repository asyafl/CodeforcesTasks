using System;
using System.Linq;

namespace A_theatreSq
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, n, m, n_a, m_a, res;
            var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            n = int.Parse(mass[0]);
            m = int.Parse(mass[1]);
            a = int.Parse(mass[2]);
            n_a = n / a;
            m_a = m / a;
            if ((n * m) <= (a * a)) 
            {
                res = 1;
            }
           
            else
            {
                if (n % a == 0 & m % a == 0)
                {
                    res = n_a * m_a;
                } 
                else if (m % a == 0) 
                {
                    res = n_a * m_a + m_a;
                }
                else if (n % a == 0)
                {
                    res = n_a * m_a + n_a;
                }
                else
                    res = n_a * m_a + m_a + n_a + 1;
            }
            Console.WriteLine(res);
            
        }
    }
}