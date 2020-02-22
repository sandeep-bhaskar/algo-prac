using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class TernarySearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 9, 0, list.Count - 1));
        }

        public static int Search(List<int> list, int searchVal, int startPos, int endPos)
        {
            if (endPos >=1)
            {
                int mid1 = startPos + (endPos - startPos) / 3;
                int mid2 = mid1 + (endPos - startPos) / 3;

                if (list[mid1] == searchVal)
                    return mid1;

                if (list[mid2] == searchVal)
                    return mid2;

                if (list[mid1] > searchVal)
                    return Search(list, searchVal, 1, mid1 - 1);

                if (list[mid2] < searchVal)
                    return Search(list, searchVal, mid2 + 1, endPos);

                return Search(list, searchVal, mid1 + 1, mid2 - 1);
            }
            return -1;
        }
    }
}
