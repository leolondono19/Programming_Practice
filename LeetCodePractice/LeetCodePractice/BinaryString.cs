using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodePractice
{
    class BinaryString
    {
        public string AddBinary(string a, string b)
        {
            int lengthA = a.Length;
            int lengthB = b.Length;
            string longString, shortString;
            char carry = '0';
            string result = "";

            if (lengthA >= lengthB)
            {
                longString = a;
                shortString = b;
            }
            else
            {
                longString = b;
                shortString = a;
            }

            int longIdx = longString.Length - 1;
            int shortIdx = shortString.Length - 1;

            while (longIdx >= 0)
            {
                (char result, char carry) test;
                if (shortIdx >= 0)
                {
                    test = AddBinaryDigits(longString[longIdx], shortString[shortIdx], carry);
                }
                else
                {
                    test = AddBinaryDigits(longString[longIdx], '0', carry);
                }
                longIdx--;
                shortIdx--;
                carry = test.carry;
                result = result.Insert(0, test.result.ToString());
            }
            if (carry == '1')
            {
                result = result.Insert(0, "1");
            }
            return result;
        }
        public (char result, char carry) AddBinaryDigits(char a, char b, char c)
        {
            if (a != b)
            {
                if(c == '0')
                {
                    return ('1', '0');
                }
                else
                {
                    return ('0', '1');
                }
            }
            else if (a == '0' && b == '0')
            {
                if (c == '0')
                {
                    return ('0', '0');
                }
                else
                {
                    return ('1', '0');
                }
            }
            else if (a == '1' && b == '1')
            {
                if(c == '0')
                {
                    return ('0', '1');
                }
                else
                {
                    return ('1', '1');
                }
            }
            throw new InvalidOperationException();
        }
    }
}

/*

0101101010101011001
      0101010101010

11111
11111

0 + 0 = 0
0 + 1 = 1
1 + 0 = 1
1 + 1 = 10

0 + 0 + 0
0 + 1 + 1
1 + 0 = 
1 + 1 + 1= 11
 
 */
