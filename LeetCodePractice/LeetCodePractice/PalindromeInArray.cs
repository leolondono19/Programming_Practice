using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class PalindromeInArray
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    return word;
                }
            }
            return "";
        }

        public bool IsPalindrome(string s)
        {
            char[] palindromeArray = s.ToCharArray();
            Array.Reverse(palindromeArray);
            string reversedString = new(palindromeArray);

            if (s == reversedString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
