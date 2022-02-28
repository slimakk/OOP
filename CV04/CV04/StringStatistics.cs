using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CV04
{
    internal class StringStatistics
    {
        public string str;
        public StringStatistics (string line)
        {
            str = line;
        }
        public int WordCounter ()
        {
            int counterWords = 0;
            char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
            string[] wordArray = str.Split (splitters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordArray)
            { 
                counterWords++;
            }
            return counterWords;
        }
        public int LineCounter ()
        {
            int lineCounter = 0;
            string[] lineArray = str.Split('\n');
            foreach (string line in lineArray)
            {
                lineCounter++;
            }
            return lineCounter;
        }
        public int SentenceCounter ()
        {
            int sentenceCounter = 0;
            string[] sentenceArray = Regex.Split(str, @"[.!?] [A-Z]|[.!?]\n");
            foreach (string sentence in sentenceArray)
            {
                sentenceCounter++;
            }
            return sentenceCounter;
        }
        public string[] LongestWords ()
        {
            int i = 0;
            char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort (wordArray, (x1, x2) => x2.Length.CompareTo(x1.Length));
            int maxLength = wordArray[0].Length;
            foreach (string word in wordArray)
            {
                int length = word.Length;
                if(length >= maxLength)
                {
                    i++;
                }
            }
            string[] longestWords = new string[i];
            for (int j = 0; j < longestWords.Length; j++)
            {
                longestWords[j] = wordArray[j];
            }
            return longestWords;
        }
        public string[] ShortestWords()
        {
            int i = 0;
            char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray, (x1, x2) => x1.Length.CompareTo(x2.Length));
            int minLength = wordArray[0].Length;
            foreach (string word in wordArray)
            {
                int length = word.Length;
                if (length <= minLength)
                {
                    i++;
                }
            }
            string[] shortestWords = new string[i];
            for (int j = 0; j < shortestWords.Length; j++)
            {
                shortestWords[j] = wordArray[j];
            }
            return shortestWords;
        }
        public string[] AlphabeticalOrder()
        {
            char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray, (x1, x2) => x1.Length.CompareTo(x2.Length));
            return wordArray;
        }
        public string[] FrequentWords ()
        {
            char[] splitters = new char[] { ' ', '.', ',', ';', '!', '?', '\n' };
            string[] wordArray = str.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
            var frequency = new Dictionary<string, int>();
            int cases = 0;
            foreach (string word in wordArray)
            {
                int count;
                frequency.TryGetValue(word, out count);
                count++;
                frequency[word] = count;
            }
            string mostFrequent = null;
            foreach (var pair in frequency)
            {
                if(pair.Value > cases)
                {
                    cases = pair.Value;
                    mostFrequent = pair.Key;
                }
            }
            int maxCases = frequency.Values.Max();
            int i = 0;
            int j = 0;
            foreach (var pair in frequency)
            {
                if (pair.Value == maxCases)
                {
                    i++;
                }
            }
            string[] frequentWords = new string[i];
            foreach (var pair in frequency)
            {
                if (pair.Value == maxCases)
                {
                    frequentWords[j] = pair.Key;
                    j++;
                }
            }
            return frequentWords;
        }
    }
}
