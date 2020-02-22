using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting.Sorting
{
    public class InsertionSort : IPracticeExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 5, 6, 4, 6, 10, 9, 8, 5 };
            PrintSortedList(list);
        }
        public void PrintSortedList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j]>key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }

            list.ForEach(_ => Console.WriteLine(_));
        }
    }
}
