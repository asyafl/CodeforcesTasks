using System;
//Необходимо вывести  строку yes, если символ является цифрой, и строку no в противном случае.
namespace IsChar102
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch = Console.ReadLine();
            if (Char.IsDigit(char.Parse(ch)))
            Console.WriteLine("yes");

            else

                Console.WriteLine("no");
            Console.ReadKey();
        }

        
    }
}
