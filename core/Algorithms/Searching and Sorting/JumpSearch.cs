using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class JumpSearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 6));
        }

        private int Search(List<int> list, int searchVal)
        {
            int step = (int)Math.Floor(Math.Sqrt(list.Count));

            int prev = 0;
            while (list[Math.Min(step, list.Count - 1)] < searchVal)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(list.Count));
                if (prev > list.Count)
                    return -1;
            }

            while (list[prev] < searchVal)
            {
                prev++;
                if (prev == Math.Min(step, list.Count))
                    return -1;
            }
            if (list[prev] == searchVal)
                return prev+1;
            return -1;
        }
    }
}
