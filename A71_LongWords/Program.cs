using System;

namespace A71_LongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string [] mass = new string[int.Parse(n)];

            for (int i = 0; i < int.Parse(n); i++)
            {
                
                mass[i] = Console.ReadLine();
               
            }

            for (int i = 0; i < int.Parse(n); i++)
            { 
                if(mass[i].Length < 11)
                {
                    Console.WriteLine(mass[i]);
                }
                else
                    Console.WriteLine("{0}{1}{2}", mass[i][0], mass[i].Length - 2, mass[i][mass[i].Length - 1]);
            }
            
        }
    }
}
