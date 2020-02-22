using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting
{
    public class LinearSearch : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 5, 6, 4, 6, 8, 5 };
            Console.WriteLine(Search(list, 6));
        }

        public static int Search(List<int> list, int searchVal)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchVal) return i;
            }

            return -1;
        }
    }
}
