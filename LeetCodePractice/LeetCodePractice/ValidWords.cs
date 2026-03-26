using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ValidWords
    {
        public int CountValidWords(string sentence)
        {
            HashSet<char> punctuations = new HashSet<char> { ',', '.', '!' };
            int result = 0;
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (isValidWord(word, punctuations))
                {   
                    result++;
                }
            }
            return result;
        }
        public bool isValidWord(string word, HashSet<char> punctuations)
        {
            int numberOfHyphens = 0;
            bool isPunctuationMark = false;
            bool isHyphen = false;
            if (word[0] == '-' || word[word.Length - 1] == '-')
            {
                return false;
            }
            foreach (var character in word)
            {
                int ascii = (int)character;
                if (ascii >= 48 && ascii <= 57)
                {
                    return false;
                }
                if( isHyphen && punctuations.Contains(character))
                {
                    return false;
                }
                isHyphen = false;
                if (character == '-')
                {
                    isHyphen = true;
                    numberOfHyphens++;
                    if (numberOfHyphens > 1)
                    {
                        return false;
                    }
                }
                if (isPunctuationMark)
                {
                    return false;
                }
                if (punctuations.Contains(character))
                {
                    isPunctuationMark = true;
                }
            }
            return true;
        }
    }
}

/*
 "!this  1-s b8d!"
1

 
 
 */
