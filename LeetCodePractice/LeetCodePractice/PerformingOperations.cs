using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class PerformingOperations
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            //(string increment1, string increment2) incrementWays = ("++X", "X++");
            //(string decrement1, string decrement2) decrementWays = ("--X", "X--");
            (string increment1, string increment2)  = ("++X", "X++");
            (string decrement1, string decrement2)  = ("--X", "X--");
            int result = 0;

            foreach (var item in operations)
            {
                if (item == decrement1 || item == decrement2)
                {
                    result--;
                }
                else
                {
                    result++;
                }
            }
            return result;
        }
    }
}
