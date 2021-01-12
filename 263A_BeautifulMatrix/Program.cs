using System;

namespace _263A_BeautifulMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] task = new string[25];
            int position = 1;

            for (int i = 0; i < 5; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = i*5, k = 0; j < 25 & k<5; j++, k++)
                {
                task[j] = mass[k];
                }
             }

            for (int i =0; i < 25; i++)
            {
                if (task[i] == "0")
                {
                    position += 1;
                }
                else
                    break;
            }

            double caseNum = Math.Ceiling(position / 5.0);
            int caseMod = position % 5;
            if (caseMod == 0)
            {
                caseMod = 5;
            }

            if(caseMod == 3)
            {
                Console.WriteLine(Math.Abs(caseNum - caseMod));
                
            }
            else
            {
                caseNum = Math.Abs(caseNum - 3) + Math.Abs(caseMod - 3);
                Console.WriteLine(caseNum);
            }
        }
    }
}
