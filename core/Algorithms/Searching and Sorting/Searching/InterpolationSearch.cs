using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class InterpolationSearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 9));
        }

        public int Search(List<int> list,int searchVal)
        {
            int lo = 0, hi = list.Count - 1;
            while (lo < hi && searchVal > list[lo] && searchVal < list[hi])
            {
                if (lo == hi)
                {
                    if (list[lo] == searchVal)
                        return lo + 1;
                    return -1;
                }
                int pos = lo + ((hi - lo) / ((list[hi] - list[lo]) * (searchVal - list[lo])));

                if (list[pos] == searchVal)
                    return pos;

                if (list[pos] < searchVal)
                    lo = pos + 1;
                else
                    hi = pos - 1;
            }
            return -1;
        }
    }
}
