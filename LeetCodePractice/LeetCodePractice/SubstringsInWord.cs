using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class SubstringsInWord
    {
        public int NumOfStrings(string[] patterns, string word)
        {
            int numberOfStrings = 0;
            foreach (var item in patterns)
            {
                if(word.Contains(item))
                {
                    numberOfStrings++;
                }
                else
                {
                    continue;
                }
            }
            return numberOfStrings;
        }
    }
}

/*
 PROBLEMA:
Tenemos una cadena de strings y una palabra string
Se debe contar la cantidad de strings de la cadena, que son parte o estan dentro de la palabra

EJEMPLO:    
Input: patterns = ["a","abc","bc","d"], word = "abc"
Output: 3
Explanation:
- "a" appears as a substring in "abc".
- "abc" appears as a substring in "abc".
- "bc" appears as a substring in "abc".
- "d" does not appear as a substring in "abc".
3 of the strings in patterns appear as a substring in word.

SOLUCION:
Primero agarraremos los strings de la cadena en orden
Verificaremos si el string que se agarro, se jhace presente dentro de la palabra
si es asi, se suma a un contador, en caso de que no se encuentre en la palabra, se continuara revisando
hasta acabar con todas las palabras de la cadena.
 
 */
