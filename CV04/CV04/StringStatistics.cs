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
        public string[] longestWords ()
        {
            int longestWords = 0;
            string[] wordArray = Regex.Split(str, @"\n|\s*\W");
            foreach(string word in wordArray)
            {
                int i = word.Length;
                if (i > longestWords)
                {

                }
            }
        }
    }
}
