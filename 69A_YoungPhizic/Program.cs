using System;

namespace _69A_YoungPhizic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] task = new int[3*n];
            int position = 0, el1=0, el2=0, el3=0;

            for (int i = 0; i < n; i++)
            {
                var mass = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = i * 3, k = 0; j < task.Length & k < 3; j++, k++)
                {
                    task[j] = int.Parse(mass[k]);
                }
            }


            for (int i =0; i<task.Length; i++)
            {
                position =(i+1) % 3;

                if(position == 0)
                {
                    el3 += task[i];
                }
                else if (position == 1)
                {
                    el1 += task[i];
                }
                else
                {
                    el2+= task[i];
                }
            }
            
            if(el1 ==0 & el2 ==0 & el3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
