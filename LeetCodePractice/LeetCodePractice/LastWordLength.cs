using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class LastWordLength
    {
        public int LengthOfLastWord(string s)
        {
            string[] subString = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int length = subString[subString.Length - 1].Length;
            return length;
        }
    }
}
/*
Estrategia:
Dividir el string principal es sub strings
almacenarlos en una cadena de strings
sacar el tamano de el ultimo sub string
 */
