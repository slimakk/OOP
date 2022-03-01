using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CV04
{
    class StringStatistics
    {
        private string str;
        private char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n', '(', ')' };
        public StringStatistics(string line)
        {
            str = line;
        }
        public int WordCounter()
        {
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            return wordArray.Length;
        }
        public int LineCounter()
        {
            string[] lineArray = str.Split('\n');
            return lineArray.Length;
        }
        public int SentenceCounter()
        {
            string[] sentenceArray = Regex.Split(str, @"[.!?] [A-Z]|[.!?]\n");
            return sentenceArray.Length;
        }
        public string[] LongestWords()
        {
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray, (x1, x2) => x2.Length.CompareTo(x1.Length));
            int maxLength = wordArray[0].Length;
            StringBuilder longestWords = new StringBuilder();
            foreach (string word in wordArray)
            {
                int length = word.Length;
                if (length >= maxLength)
                {
                    longestWords.AppendLine(word);
                }
            }
            return longestWords.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
        public string[] ShortestWords()
        {
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray, (x1, x2) => x1.Length.CompareTo(x2.Length));
            int minLength = wordArray[0].Length;
            StringBuilder shortestWords = new StringBuilder();
            foreach (string word in wordArray)
            {
                int length = word.Length;
                if (length <= minLength)
                {
                    shortestWords.AppendLine(word);
                }
            }
            return shortestWords.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
        public string[] AlphabeticalOrder()
        {
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray);
            return wordArray;
        }
        public string[] FrequentWords()
        {
            string lowerWords = str.ToLower();
            string[] wordArray = lowerWords.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            var frequency = new Dictionary<string, int>();
            foreach (string word in wordArray)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }
            int maxCases = frequency.Values.Max();
            StringBuilder frequentWords = new StringBuilder();
            foreach (var pair in frequency)
            {
                if (pair.Value == maxCases)
                {
                    frequentWords.AppendLine(pair.Key);
                }
            }
            return frequentWords.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
