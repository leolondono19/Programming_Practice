using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ExcelToTittle
    {
        public string ConvertToTitle(int columnNumber)
        {
            string result = "";
            char letter = ' ';
            while (columnNumber != 0)
            {
                columnNumber -= 1;
                letter = (char)((columnNumber % 26) + 65);
                result = result.Insert(0, letter.ToString());
                columnNumber /= 26;
            }
            return result;
        }

        public void Rest1(List<char> column)
        {
            int asciiLetter = (int)column[column.Count - 1] - 1;
            if (asciiLetter == 64)
            {
                column[column.Count - 1] = 'Z';
                return;
            }
            column[column.Count - 1] = (char)asciiLetter;
            column.Add('Z');
        }
    }
}

/*
 * A -> Z
 * B -> AZ
 * BZ -> BYZ
 * 
 * 
 * 
 * 1  -> A -> 65
 * 26 -> Z -> 90
 * 27 -> AA
 * 
 * 28 -> 28/26=1=A -> 28%26=2=B -> AB   
 * 84 -> 84/26=3=C -> 84%26=6=F -> CF
 * 26 -> 26/26=1=A -> 26%26=0 -> A-1=Z
 * 52 -> 52/26=2=b -> 52%26=0 -> B-1=AZ
 * 
 * 
 * 
 * 1001 -> 1001/26=38 -> 38/26=1=A -> 38%26=12=L -> 1001%26=13=M  -> ALM
 * 
 * 
 * 2028 -> 2028/26= 78 -> 78/26=3=C -> 78%26=0 -> C-1=BZ -> 2028%26=0 -> BZ-1=BYZ
 * result = C
 * counter = 2;
 *  
 *  result = C -> C-1=BZ -> BZ-1=BYZ
 *  stack = 
 *  
 * 
 * SOLUTION IDEA:
 * 1001 -> 1001%26=13=M -> 1001/26=38 -> 38%26=12=L -> 38/26=1=A
 * result = ALM
 * counter = 0;
 * 
 * 2028 -> 2028%26=0 -> 2028/26=78 -> 78%26=0 -> 78/26=3=C
 * result = C-1=BZ -> BZ-1=BYZ
 * counter = 0
 * 
 * 2028 -> 2028%26=0 -> 2028/26=78 -> 78%26=0 -> 78/26=3=C
 * result = 
 * counter = 2
 * 
 * 16244 -> 16244%26=20=T -> 16244/26=624 -> 624%26=0 -> 624/26=24=X ->
 * result = WZT
 * WZT RESULT
 * counter = 1
 * 
 * 16250 -> 16250%26=0 -> 16250/26=625 -> 625%26=1=A -> 625/26=24=X
 * result = A-1=XZZ
 * counter = 0
 * 
 * 16250 -> 16250/26=625 -> 625/26=24 -> 625%26=1=A -> 16250%26=0
 * result = XA
 * stack = 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 public string ConvertToTitle(int columnNumber)
        {
            char letter1 = ' ';
            char letter2 = ' ';
            string result = "";
            int firtsLetter = 0;
            int secondLetter = 0;

            if (columnNumber <= 26)
            {
                firtsLetter = 64 + columnNumber;
                letter1 = (char)firtsLetter;
                result = letter1.ToString();
                return result;
            }
            firtsLetter = 64 + (columnNumber / 26);
            secondLetter = 64 + (columnNumber % 26);
            letter1 = (char)firtsLetter;
            if (secondLetter != 64)
            {
                letter2 = (char)secondLetter;
                result = letter1.ToString() + letter2.ToString();
            }
            else
            {
                return letter1.ToString();
            }
            return result;
        }
 
 */
