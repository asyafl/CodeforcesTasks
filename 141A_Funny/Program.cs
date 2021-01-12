using System;
using System.Linq;

namespace _141A_Funny
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = Console.ReadLine();
            string hostName = Console.ReadLine();
            string pile = Console.ReadLine();
            int resg = 0 , resh = 0;


            foreach (char d in hostName)
            {
                for (int i = 0; i < pile.Length; i++)
                {
                    if (pile[i].Equals(d))
                    {

                        pile = pile.Remove(i, 1);
                        resh++;
                        break;
                    }
                }
            }

            foreach (char d in guestName)
            {
                for (int i = 0; i < pile.Length; i++)
                {
                    if (pile[i].Equals(d))
                    {

                        pile = pile.Remove(i, 1);
                        resg++;
                        break;
                    }
                }
            }
            Console.WriteLine(guestName.Length == resg && hostName.Length == resh && pile.Length == 0 
                                    ? "YES" 
                                    : "NO");

        }
    }
}
