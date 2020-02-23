using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Algorithms.Pattern_Searching
{
    public class NaiveSearch : IExecutor
    {
        public string Text { get; set; }
        public string Pattern { get; set; }

        public void Execute()
        {           
            Console.WriteLine("---------------------Pattern Searching (Naive Seacrhing Algorithm)-----------------------");
            Console.WriteLine("-- It checks for all character of the main string to the pattern.\n-- This algorithm is helpful for smaller texts.");
            Console.WriteLine("-- The time complexity of Naïve Pattern Search method is O(m*n).\n-- The m is the size of pattern and n is the size of the main string.");
            Console.WriteLine("Program started...........");
            Console.WriteLine("Please Enter Text.");
            this.Text = Console.ReadLine();
            Console.WriteLine("Please Enter Pattern.");
            this.Pattern = Console.ReadLine();
            this.NaivePatternSearch();
        }

        public void NaivePatternSearch()
        {
            int patLen = this.Pattern.Length;
            int strLen = this.Text.Length;
            for (int i = 0; i <= (strLen - patLen); i++)
            {
                int j = 0;
                for (; j < patLen; j++)
                {      //check for each character of pattern if it is matched
                    if (this.Text[i + j] != this.Pattern[j])
                        break;
                }
                if (j == patLen)
                {     //the pattern is found
                    Console.WriteLine($"Pattern found at {i}");
                }
            }
        }
    }
}
