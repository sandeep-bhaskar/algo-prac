using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Searching_and_Sorting.Sorting
{
    public class BubbleSort : IExecutor
    {
        public void Execute()
        {
            List<int> list = new List<int>() { 1, 5, 6, 4, 6,10,9, 8, 5 };
            PrintSortedList(list);
        }

        public void PrintSortedList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            list.ForEach(_ =>
            {
                Console.WriteLine(_);
            });
        }
    }
}
