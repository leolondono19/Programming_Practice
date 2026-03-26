using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class ExtraCharacters
    {
        public int MinExtraChar(string s, string[] dictionary)
        {
            Array.Sort(dictionary, (a, b) => a.Length.CompareTo(b.Length));
            Array.Reverse(dictionary);
            int result = 0;
            char[] replacedString = s.ToCharArray();
            int position = 0;
            int increment = 0;
            for (int i = 0; i < dictionary.Length; i++)
            {
                position = s.IndexOf(dictionary[i], position + increment);
                if (position == -1)
                {
                    position = 0;
                    increment = 0;
                    continue;
                }
                for (int j = 0; j < dictionary[i].Length; j++)
                {
                    replacedString[position + j] = '*';
                }
                i--;
                increment = 1;
            }
            result = replacedString.Count((a) => a != '*');
            return result;
        }
    }
}
/*
 * "pdfvt", "aiyzi", "aokas", "bnsll", "cgmud", "rvegf", "pfctr", "ybbcl", "ilhqd", "pirua", "cyys", 
 * "zdhx", "jjqf", "wcaz", "vbmi", "fxyx", "bmab", "okgk", "fux", "iak", "mvo", "xaw", "mra", "uwb", 
 * "ysg", "biu", "lpl", "flr", "ad", "wq", "lw", "xo", "jf", "xv", "yv", "xf", "ke", "hv", "ip", "r", 
 * "g", "v", "t", "e"
 * "ke v lpl xo zai zdhx oim mra iak bak"
 * "** * *** ** zai **** *im *** *** bak"
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * "rkmsi", "cfybt", "lwoim", "tofxe", "jgodm", "demij", "ofeyx", "hdzeg", "akjtl", "ymdt", "cpir", 
 * "eqru", "llqs", "lxoi", "tjky", "ernt", "jfns", "lyso", "etjx", "uqm", "afy", "ncz", "wt", "jx", 
 * "tp", "th", "tk", "zg", "kt", "d", "p", "l", "e", "r", "y"
    rkmsi l izk tp r l lwoim afy uqm eqru jx d zg p
 *  ***** * izk ** * * ***** *** *** **** ** * ** *
 * 
 * 
 * 
 * ["kzbu","tskz","cehy","txhe",'wmo',"nuq","ksv","diz","ds","ox","lb","gu","v","o","r","e"]
 * "dwmodizxvvbosxxw"
 * d*x**b*sxxw
 * 
 * 
 * 
//  ["ox","lb","diz","gu","v","ksv","o","nuq","r","txhe","e",'wmo',"cehy","tskz","ds","kzbu"]
//  "dwmodizxvvbosxxw"
//  "d 'wmo' 'diz' x 'v' 'v' b 'o' sxxw"




- Obtener tamano del string crrespondiente
- 






ave aar

ba ar



PROBLEMA:
Se debe encontrar las palabras de el diccionario en el string
Lo que no se encuentre en el diccionario son caracteres sin usarse



SOLUCION:
Primero se agarria los valores de la cadena de strings uno por uno
Se ve si el string s contiene ese valor de la cadena
Si lo contiene, esa parte del string s, se eliminara de s
Una vez se termine de comparar todos los valores de la cadena, se vera el tamaño sobrante del string s y ese
sera el valor de caracteres restantes.

 
 
int position = 0;
            int result = 0;
            foreach (var item in dictionary)
            {
                position = s.IndexOf(item);
                if (position != -1)
                {
                    s = s.Remove(position, item.Length);
                }
                result = s.Length;
            }
            return result;







position = replacedString.IndexOf(item);
                    string charactersToInsert = new('*', item.Length);
                    replacedString = replacedString.Remove(position, item.Length);
                    replacedString = replacedString.Insert(position, charactersToInsert);


PRIMERA CERSION:
public class Solution {
    public int MinExtraChar(string s, string[] dictionary)
    {
        Array.Sort(dictionary, (a, b) => a.Length.CompareTo(b.Length));
        Array.Reverse(dictionary);
        int result = 0;
        foreach (var item in dictionary)
        {
            if (s.Contains(item))
            {
                s = s.Replace(item, "*");
            }
        }
        result = s.Count((a) => a != '*');
        return result; ;
    }
}
 */
