using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class PrefixOfArray
    {
        public bool IsPrefixString(string s, string[] words)
        {
            string prefix = "";
            bool prefixOfArray = false;
            for (int i = 0; i < words.Length; i++)
            {
                prefix += words[i];
                if (s.StartsWith(prefix))
                {
                    if(s == prefix)
                    {
                        prefixOfArray = true;
                        break;
                    }
                }
                else
                {
                    prefixOfArray = false;
                    break;
                }
            }
            return prefixOfArray;
        }
    }
}



/*
 Estrategia 1:
Compararemos un substring con s que es el prefijo
Cada word se ira concatenando a un substring el cual se comparara con el prefijo
se verificara si el tamano de ambas coincide para retornar verdadero y asegurar que es su prefijo

Estrategia 2 


Input: s = "iloveleetcode", 


words = ["i","love","leetcode","apples"]
Output: true


Explanation:
s can be made by concatenating "i", "love", and "leetcode" together.
 




public bool IsPrefixString(string s, string[] words)
        {
            string ConcatenatedWords = string.Concat(words);
            if(ConcatenatedWords.StartsWith(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 */