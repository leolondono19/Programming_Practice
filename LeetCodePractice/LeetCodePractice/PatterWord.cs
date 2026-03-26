using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class PatterWord
    {
        public bool WordPattern(string pattern, string s)
        {
            //_ = new Dictionary<char, string>();
            Dictionary<char, string> patternDictionary = new();
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length != pattern.Length)
            {
                return false;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (!patternDictionary.ContainsKey(pattern[i]))
                {
                    if (!patternDictionary.ContainsValue(words[i]))
                    {
                        patternDictionary.Add(pattern[i], words[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (patternDictionary[pattern[i]] == words[i])
                {
                    continue;
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
   Problema:
  Tenemos 2 strings
  uno que es un conjunto de palabras
  otro que es una sola palabra, conjunto de caracteres
  debemos 
   
   
   
   
   
   */


