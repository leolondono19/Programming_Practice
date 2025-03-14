using LeetCodePractice;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        string[] test = {"flower", "", "flower" };
        LongestPrefix longestPrefix = new LongestPrefix();
        string result = longestPrefix.LongestCommonPrefix(test);
        Console.WriteLine(result);
        */
        /*
        string test = "MCMXCIV";
        RomanNumbers romanNumbers = new RomanNumbers();
        int result = romanNumbers.RomanToInt(test);
        Console.WriteLine(result);
        */
        /*
        string test1 = "sadbutsad";
        string needle = "sad";
        FirstOccurrences firstOccurrences = new FirstOccurrences();
        int result = firstOccurrences.StrStr(test1, needle);
        Console.WriteLine(result);
        */
        /*
        string test = "iiii";
        SumOfDigits sumOfDigits = new SumOfDigits();
        int result = sumOfDigits.GetLucky(test, 1);
        Console.WriteLine(result);
        */
        /*
        string word = "zb";
        MinimumTime minimumTime = new MinimumTime();
        int result = minimumTime.MinTimeToType(word);
        Console.WriteLine(result);
        */
        /*
        string test = "luffy is still joyboy";
        LastWordLength lastWordLength = new LastWordLength();
        int result = lastWordLength.LengthOfLastWord(test);
        Console.WriteLine(result);
        */
        /*
        string test = "a";
        string[] words = { "aa", "aaaa", "banana" };
        PrefixOfArray prefixOfArray = new PrefixOfArray();
        bool result = prefixOfArray.IsPrefixString(test, words);
        Console.WriteLine(result);
        */
        /*
        string word = "aaaaabbbbb";
        string[] subWords = { "a", "b", "c" };
        SubstringsInWord substringsInWord = new SubstringsInWord();
        int result = substringsInWord.NumOfStrings(subWords, word);
        Console.WriteLine(result);
        */
        /*
        string a = "1";
        string b = "1";
        BinaryString binaryString = new BinaryString();
        string result = binaryString.AddBinary(a, b);
        Console.WriteLine(result);
        */

        string test = "abcdefd";
        char ch = 'd';
        ReversePrefixOfWord reversePrefixOfWord = new ReversePrefixOfWord();
        string result = reversePrefixOfWord.ReversePrefix(test, ch);
        Console.WriteLine(result);
    }









    public static bool AreOccurrencesEqual(string s)
    {
        int currentValue = 0;
        Dictionary<char, int> CounterDictionary = new Dictionary<char, int>();
        foreach (var item in s)
        {
            if (CounterDictionary.ContainsKey(item))
            {
                CounterDictionary[item]++;
            }
            else
            {
                CounterDictionary.Add(item, 1);
            }
        }

        foreach (var item in CounterDictionary.Values)
        {
            if(currentValue == 0)
            {
                currentValue = item;
            } else
            {
                if (currentValue != item)
                    return false;
            }

        }
        return true;
    }
}