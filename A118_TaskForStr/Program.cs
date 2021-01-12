using System;

namespace A118_TaskForStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower();
            
            char[] mass = new char[6] { 'a', 'o', 'y', 'e', 'u', 'i' };

            for (int i = 0; i < str.Length; i++)
            {
                foreach (char d in mass)
                {
                    if (str[i].Equals(d))
                    {
                        
                        str = str.Replace(str[i], ' ');
                    }

                }
            }
            str = str.Replace(" ", "");
                for (int i = 0; i < str.Length; i+=2)
                {
                    str = str.Insert(i,".");
                    
                }
            
            Console.WriteLine(str);
        }
    }
}
