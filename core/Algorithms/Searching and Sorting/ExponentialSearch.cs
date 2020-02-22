using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class ExponentialSearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(Search(list, 9));
        }

        public static int Search(List<int> list, int searchVal)
        {
            if (list[0] == searchVal)
                return 0;
            int i = 1;
            while (i < list.Count && list[i] < searchVal)
                i *= 2;

            return B_Search(list, searchVal, i / 2, Math.Min(i, (list.Count - 1)));
        }

        static int B_Search(List<int> list, int searchValue, int startPos, int endPos)
        {
            if (endPos > 1)
            {
                var mid = (startPos + endPos) / 2;

                if (list[mid] == searchValue)
                    return mid;

                if (list[mid] > searchValue)
                    B_Search(list, searchValue, startPos, mid - 1);

                return B_Search(list, searchValue, mid + 1, endPos);
            }
            return -1;
        }
    }
}
