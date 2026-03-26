using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string originString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
            char[] palindromeArray = originString.ToCharArray();
            Array.Reverse(palindromeArray);
            string reversedString = new(palindromeArray);

            if (originString == reversedString)
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
