using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ReversePrefixOfWord
    {
        public string ReversePrefix(string word, char ch)
        {
            int startPosition = word.IndexOf(ch) + 1;
            int endPosition = word.Length - startPosition;
            string reverseString = word.Substring(0, startPosition);
            string remainingString = word.Substring(startPosition, endPosition);
            char[] charArray = reverseString.ToCharArray();
            Array.Reverse(charArray);
            word = string.Concat(charArray) + remainingString;
            //word = new string(charArray);
            return word;
        }
    }
}
