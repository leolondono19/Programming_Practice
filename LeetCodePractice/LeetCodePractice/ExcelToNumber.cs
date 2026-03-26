using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ExcelToNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            int letterPosition = 0;
            int n = columnTitle.Length;
            foreach (var letter in columnTitle)
            {
                n--;
                letterPosition = (int)letter - 64;
                result += letterPosition * (int)Math.Pow(26, n);
            }
            return result;
        }
    }
}

/*
 FORMULA:
 letra#n * 26^(n-1)
ASD
600
 62
  2
 
 */
