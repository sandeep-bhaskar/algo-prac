using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class BinarySearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 9, 0, list.Count));
        }

        public int Search(List<int> list, int searchVal, int startIndex, int lastIndex)
        {
            if (lastIndex > 0)
            {
                int mid = (startIndex + lastIndex) / 2;

                if (list[mid] == searchVal)
                {
                    return mid;
                }

                if (list[mid] > searchVal)
                {
                    return Search(list, searchVal, startIndex, mid - 1);
                }

                return Search(list, searchVal, mid + 1, lastIndex);
            }
            return -1;
        }
    }
}
