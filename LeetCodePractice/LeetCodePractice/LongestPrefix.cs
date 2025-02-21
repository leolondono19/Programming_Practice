using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class LongestPrefix
    {
        public string LongestCommonPrefixOld(string[] strs)
        {
            string result = "";
            char lastLetter = ' ';
            int counter = 0;
            for (int i = 0; i <= strs.Length - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (lastLetter == strs[i][j])
                    {
                        counter++;
                    }
                    else if (counter == 1)
                    {
                        counter = 0;
                        continue;
                    }
                    if (counter == 2)
                    {
                        counter = 0;
                        result += lastLetter;
                    }
                    lastLetter = strs[i][j];
                }
            }
            return result;
        }
            
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            char letter = ' ';
            int counter = 0;
            int sizeLetter = 200;

            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < sizeLetter)
                {
                    sizeLetter = strs[i].Length;
                }
            }

            while (sizeLetter > counter)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (i == 0)
                    {
                        letter = strs[i][counter];
                    }
                    if (letter != strs[i][counter])
                    {
                        return result;
                    }
                }
                result += letter;
                counter++;
            }
            return result;
        }
    }

    /*
     ["flower","flow","flight"]
     ["bed","bed","bed"]

     Prefijos comunes, nada mas

    Definir problema - Definir solucion - Implementar solucion paso a paso
    - Revisar una sola letra de cada palabra
    - Comparar las letras
    - Si son iguales, se añade al string resultado
    - Si una letra ya es diferente, el proceso termina 

     
     */
}
