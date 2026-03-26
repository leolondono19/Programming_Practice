using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class VowelSubstrings
    {
        public int CountVowelSubstrings(string word)
        {
            int counter = 0;
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < word.Length; i++)
            {
                if (!vowels.Contains(word[i]))
                {
                    continue;
                }
                HashSet<char> vowelSubstring = new HashSet<char>();
                for (int j = i; j < word.Length && vowels.Contains(word[j]); j++)
                {
                    vowelSubstring.Add(word[j]);
                    if (vowelSubstring.Count == 5)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
