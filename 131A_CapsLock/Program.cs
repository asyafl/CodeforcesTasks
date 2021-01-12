using System;

namespace _131A_CapsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool registr = true;

            for(int i=1; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    registr = true;
                }
                else
                {
                    registr = false;
                    break;
                }
                    
            }
            if (registr == true & Char.IsUpper(str[0]))
            {
                Console.WriteLine(str.ToLower());
            }
            else if (registr == true & Char.IsLower(str[0]))
            {
                Console.WriteLine(str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower());
            }
            else
            {
                Console.WriteLine(str);
            }
            
 
        }
    }
}
