using LeetCodePractice;
using System.Collections;
using System.Globalization;

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
        /*
        string test = "abcdefd";
        char ch = 'd';
        ReversePrefixOfWord reversePrefixOfWord = new ReversePrefixOfWord();
        string result = reversePrefixOfWord.ReversePrefix(test, ch);
        Console.WriteLine(result);
        */
        /*
        string[] operations = { "--X", "X++", "X++" };
        PerformingOperations performingOperations = new PerformingOperations();
        int result = performingOperations.FinalValueAfterOperations(operations);
        Console.WriteLine(result);
        */
        /*
        string s = "";
        AscendingNumbers ascendingNumbers = new AscendingNumbers();
        bool test = ascendingNumbers.AreNumbersAscending(s);
        Console.WriteLine(test);
        */
        /*
        int a = 10;
        Console.WriteLine("a = " + a);
        int b = a;
        Console.WriteLine("b = " + b);
        b = 20;
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.WriteLine("************************************************");

        String c = "10";
        Console.WriteLine("c = " + c);
        String d = c;
        Console.WriteLine("d = " + d);
        d = "20";
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);

        Console.ReadLine();
        */
        /*

        string[] dictionary = { "yv", "bmab", "hv", "bnsll", "mra", "jjqf", "g", "aiyzi", "ip", "pfctr", "flr", "ybbcl", "biu", "ke", "lpl", "iak", "pirua", "ilhqd", "zdhx", "fux", "xaw", "pdfvt", "xf", "t", "wq", "r", "cgmud", "aokas", "xv", "jf", "cyys", "wcaz", "rvegf", "ysg", "xo", "uwb", "lw", "okgk", "vbmi", "v", "mvo", "fxyx", "ad", "e" };
        string s = "kevlplxozaizdhxoimmraiakbak";
        ExtraCharacters extraCharacters = new ExtraCharacters();
        int result = extraCharacters.MinExtraChar(s, dictionary);
        Console.WriteLine(result);
        Array.Sort(dictionary, (a, b) => a.Length.CompareTo(b.Length));
        Array.Reverse(dictionary);
        foreach (var item in dictionary)
        {
            Console.Write('"' + item + '"' + ", ");
        }
        */

        /*
        string pattern = "aaa";
        string s = "aa aa aa aa";
        PatterWord patterWord = new PatterWord();
        bool result = patterWord.WordPattern(pattern, s);
        Console.WriteLine(result);
        */

        /*
        string test = "XXOX";
        MovesToConvert movesToConvert = new MovesToConvert();
        int result = movesToConvert.MinimumMoves2(test);
        Console.WriteLine(result);
        */

        /*
        string[] arr = { "a", "b", "a" };
        int k = 3;
        DistinctString distinctString = new DistinctString();
        string result = distinctString.KthDistinct(arr, k);
        Console.WriteLine(result);
        */

        /*
        string s = "0P";
        ValidPalindrome validPalindrome = new ValidPalindrome();
        bool resutl = validPalindrome.IsPalindrome(s);
        Console.WriteLine(resutl);
        */
        /*
        string sentence = " 62   nvtk0wr4f  8 qt3r! w1ph 1l ,e0d 0n 2v 7c.  n06huu2n9 s9   ui4 nsr!d7olr  " +
            "q-, vqdo!btpmtmui.bb83lf g .!v9-lg 2fyoykex uy5a 8v whvu8 .y sc5 -0n4 zo pfgju 5u 4 3x,3!wl  " +
            "fv4   s  aig cf j1 a i  8m5o1  !u n!.1tz87d3 .9    n a3  .xb1p9f  b1i a j8s2 cugf l494cx1! " +
            "hisceovf3 8d93 sg 4r.f1z9w   4- cb r97jo hln3s h2 o .  8dx08as7l!mcmc isa49afk i1 fk,s e !1 " +
            "ln rt2vhu 4ks4zq c w  o- 6  5!.n8ten0 6mk 2k2y3e335,yj  h p3 5 -0  5g1c  tr49, ,qp9 -v p  " +
            "7p4v110926wwr h x wklq u zo 16. !8  u63n0c l3 yckifu 1cgz t.i   lh w xa l,jt   hpi ng-gvtk8 9 " +
            "j u9qfcd!2  kyu42v dmv.cst6i5fo rxhw4wvp2 1 okc8!  z aribcam0  cp-zp,!e x  agj-gb3 !om3934 k " +
            "vnuo056h g7 t-6j! 8w8fncebuj-lq    inzqhw v39,  f e 9. 50 , ru3r  mbuab  6  wz dw79.av2xp . " +
            "gbmy gc s6pi pra4fo9fwq k   j-ppy -3vpf   o k4hy3 -!..5s ,2 k5 j p38dtd   !i   b!fgj,nx qgif ";
        //sentence = ",e0d 7c. nsr!d7olr q-, .!v9-lg -0n4 3x,3!wl !u n!.1tz87d3 4r.f1z9w ng-gvtk8 cp-zp,!e t-6j!";
        sentence = "pencil-sharpener.";
        ValidWords validWords = new ValidWords();
        int result = validWords.CountValidWords(sentence);
        Console.WriteLine(result);
        */
        /*
        string word1 = "aaaa";
        string word2 = "bccb";
        AlmostEquivalent almostEquivalent = new AlmostEquivalent();
        bool result = almostEquivalent.CheckAlmostEquivalent(word1, word2);
        Console.WriteLine(result);
        */
        /*
        int column = 701;
        //List<char> lista = new List<char>() { 'C' };
        ExcelToTittle excelToTittle = new ExcelToTittle();
        //excelToTittle.Rest1(lista);
        string result = excelToTittle.ConvertToTitle(column);
        Console.WriteLine(result);
        */
        /*
        string word = "cuaieuouac";
        VowelSubstrings vowelSubstrings = new VowelSubstrings();
        int result = vowelSubstrings.CountVowelSubstrings(word);
        Console.WriteLine(result);
        */
        /*
        string[] words1 = { "leetcode", "is", "amazing", "as", "is" };
        string[] words2 = { "amazing", "leetcode", "is" };
        CommonWords commonWords = new CommonWords();
        int result = commonWords.CountWords(words1, words2);
        Console.WriteLine(result);
        */
        /*
        string[] words = { "def", "ghi" };
        PalindromeInArray palindromeInArray = new PalindromeInArray();
        string result = palindromeInArray.FirstPalindrome(words);
        Console.WriteLine(result);
        */
        /*
        string columnTitle = "ABCD";
        ExcelToNumber excelToNumber = new ExcelToNumber();
        int result = excelToNumber.TitleToNumber(columnTitle);
        Console.WriteLine(result);
        */

        string tittle = "capiTalIze tHe titLe";
        Capitalize capitalize = new Capitalize();
        string result = capitalize.CapitalizeTitle(tittle);
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