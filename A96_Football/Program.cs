using System;

namespace A96_Football
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string s = Console.ReadLine();
           char[] task = new char[s.Length];
            int  count = 1;

            for (int i = task.Length-1; i >= 0; i--)
            {
                task[i] = s[i];
            }


            for (int i = 1; i < task.Length & count <7; i++)
            {
                
                    if (task[i].Equals(task[i - 1]))
                    {
                        count += 1;
                    }
                    else
                        count = 1;
              
            }
            if (count == 7)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }
    }
}
