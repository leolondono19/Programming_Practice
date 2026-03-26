using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class AlmostEquivalent
    {
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            int[] frequencyWord1 = new int[26];
            int[] frequencyWord2 = new int[26];

            foreach (var letter in word1)
            {
                frequencyWord1[letter - 'a']++;
            }
            foreach (var letter in word2)
            {
                frequencyWord2[letter - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                int frequencyDifference = Math.Abs(frequencyWord1[i] - frequencyWord2[i]);
                if (frequencyDifference > 3)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
