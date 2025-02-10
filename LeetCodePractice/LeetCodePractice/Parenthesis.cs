using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class Parenthesis
    {
        public bool IsValid(string s)
        {
            Stack<char> ParenthesisStack = new Stack<char>();
            Dictionary<char, char> ParenthesisDictionary = new Dictionary<char, char>();
            ParenthesisDictionary.Add('[', ']');
            ParenthesisDictionary.Add('(', ')');
            ParenthesisDictionary.Add('{', '}');
            foreach (var item in s)
            {
                
                if (item == '(' || item == '{' || item == '[')
                {
                    ParenthesisStack.Push(item);
                }
                else
                {
                    if(ParenthesisStack.Count == 0)
                    {
                        return false;
                    }

                    var value = ParenthesisStack.Pop();
                    if (item != ParenthesisDictionary[value]) {
                        return false;
                    }
                }
            }
            if (ParenthesisStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
