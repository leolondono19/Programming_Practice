using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class Capitalize
    {
        public string CapitalizeTitle(string title)
        {
            string result = "";
            string[] words = title.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= 2)
                {
                    words[i] = words[i].ToLower();
                }
                else
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            result = string.Join(" ", words);
            return result;
        }
    }
}
