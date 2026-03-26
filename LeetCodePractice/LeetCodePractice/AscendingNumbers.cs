using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class AscendingNumbers
    {
        public bool AreNumbersAscending(string s)
        {
            int number = 0;
            int lastNumber = 0;
            string[] substrings = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in substrings)
            {
                bool isNumber = int.TryParse(item, out number);
                if (!isNumber)
                {
                    continue;
                }
                if (isNumber && lastNumber < number)
                {
                    lastNumber = number;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

/*
  
  
 Input: s = "1 box has 3 blue 4 red 6 green and 12 yellow marbles"
Output: true
Explanation: The numbers in s are: 1, 3, 4, 6, 12.
They are strictly increasing from left to right: 1 < 3 < 4 < 6 < 12.

PRIMERA 
number = 1
lastNumber = 0;

SEGUNDA
number = 3;
lastNumber = 1;

 
 
 */
