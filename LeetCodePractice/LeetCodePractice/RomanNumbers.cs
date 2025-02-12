using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    internal class RomanNumbers
    {
        public int RomanToInt(string s)
        {
            int lastValue = 0;
            int result = 0;
            Dictionary<char, int> RomanDictionary = new Dictionary<char, int>();
            RomanDictionary.Add('I', 1);
            RomanDictionary.Add('V', 5);
            RomanDictionary.Add('X', 10);
            RomanDictionary.Add('L', 50);
            RomanDictionary.Add('C', 100);
            RomanDictionary.Add('D', 500);
            RomanDictionary.Add('M', 1000);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (RomanDictionary[s[i]] >= lastValue)
                {
                    lastValue = RomanDictionary[s[i]];
                    result += RomanDictionary[s[i]];
                }
                else
                {
                    result -= RomanDictionary[s[i]];
                }
            }
            return result;
        }
    }
}
/*
     * Problema:
     * los numeros romanos tienen ciertas reglas
     * Solo se puede restar "I" "X" "C"
     * Se puede repetir hasta 3 veces las letras "I" "X" "C" "M"
     * la letra "I" se suma repetido y se resta tambien
     * 
     * Estrategia - Solucion:
     * Revisar el string de forma inversa
     * Si el valor de la derecha es menor que el de la izquierda, se suma al resultado
     * Si el valor de la izquierda es menor que el de la derecha, se le resta al resultado
     * Al ser inversa la revision sumaremos de atras hacia adelante
     * 
     * 
     * XL V
     * M CM XC VIII - 1994
     * MM
     * VV
     *  I
     *  II
     *  III
     *  IV
     */
