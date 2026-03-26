using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class CommonWords
    {
        public int CountWords(string[] words1, string[] words2)
        {
            Dictionary<string, int> countWords1 = new Dictionary<string, int>();
            Dictionary<string, int> countWords2 = new Dictionary<string, int>();
            int result = 0;

            foreach (var word in words1)
            {
                if (!countWords1.ContainsKey(word))
                {
                    countWords1.Add(word, 0);
                }
                countWords1[word]++;
            }

            foreach (var word in words2)
            {
                if (!countWords2.ContainsKey(word))
                {
                    countWords2.Add(word, 0); ;
                }
                countWords2[word]++;
            }
            foreach (var word in countWords1)
            {
                if (word.Value == 1 && countWords2.ContainsKey(word.Key) && countWords2[word.Key] == 1)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
