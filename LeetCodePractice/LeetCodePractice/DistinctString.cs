using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class DistinctString
    {
        public string KthDistinct(string[] arr, int k)
        {
            int counter = 0;
            Dictionary<string, int> repeatedValues = new();
            foreach (var item in arr)
            {
                if (repeatedValues.ContainsKey(item)) 
                {
                    repeatedValues[item]++;
                }
                else
                {
                    repeatedValues.Add(item, 1);
                }
            }
            foreach (var dicItem in repeatedValues)
            {
                if (repeatedValues[dicItem.Key] == 1)
                {
                    counter++;
                }
                if (counter == k)
                {
                    return dicItem.Key;
                }
            }
            return "";
        }
    }
}
/*
       
[a, bb, cc, bb]

a, 1
bb, 2
cc, 1

*/