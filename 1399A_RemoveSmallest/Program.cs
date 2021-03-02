using System;
using System.Collections.Generic;
using System.Linq;

namespace _1399A_RemoveSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            var mainList = new List<int>[testCase];
            for(int i = 0; i< testCase; i++)
            {
                int arrCount = int.Parse(Console.ReadLine());
                var list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => int.Parse(item))
                    .ToList();

                mainList[i] = list;
              }

            var g = new Greedy();

            for(int i = 0; i < testCase; i++)
            {
                Console.WriteLine(g.Solve(mainList[i])); ;
            }
           
        }

    }
    public class Greedy
    {
        public string Solve(List<int> list) 
        {
            var sortList = list.OrderBy(x => x).ToList();
            int count = list.Count;

            for(int i = 1; i< sortList.Count; i++)
            {
                if(sortList[i] - sortList[i - 1] < 2)
                {
                    count--;
                }
            }

            if(count > 1)
            {
                return "NO";
            }
            else { return "YES"; }
        }
    }
}
