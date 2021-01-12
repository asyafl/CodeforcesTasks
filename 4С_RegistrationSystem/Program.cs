using System;
using System.Collections.Generic;
using System.Linq;

namespace _4С_RegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] mass = new string[n];

            for (int i = 0; i < n; i++)
            {
                mass[i] = Console.ReadLine();
            }

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                
                if (dictionary.ContainsKey(mass[i]))
                {
                    dictionary[mass[i]]++;
                }
                else
                {
                    dictionary.Add(mass[i], 0);
                }
                    
                Console.WriteLine(dictionary[mass[i]] > 0 ? mass[i] + dictionary[mass[i]] : "OK");
            }


        }
    }
}
