using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class SumOfDigits
    {
        public int GetLucky(string s, int k)
        {
            string StringNumber = "";
            ulong numberToSolve;
            foreach (var item in s)
            {
                int numberOfLetter = (int)item - 96;
                StringNumber = StringNumber + numberOfLetter.ToString();
            }
            numberToSolve = Convert.ToUInt64(StringNumber);
            while (k > 0)
            {
                
            }
            return k;
        }
    }
}


/*
Definicion del problema:
Se tiene un string que es un conjunto de letras, cada letra tiene un valor numerico, el cual se debe encontrar
Una vez que se tenga, se debe sumar los valores numericos la cantidad de veces que indique el argumento k

Estrategia:

Debemos darle un valor numerico a todas las letras del alfabeto
Obtenemos el valor directamente mediante casteo pero este se resta 96
obtenido el valor, lo convertimos a string nuevamente y lo vamos añadiendo uno por uno a un string que sera el numero a sumar
el numero a sumar se convierte a int




Input: s = "leetcode", k = 2

Output: 6

Explanation:

The operations are as follows:
- Convert: "leetcode" ➝ "(12)(5)(5)(20)(3)(15)(4)(5)" ➝ "12552031545" ➝ 12552031545
- Transform #1: 12552031545 ➝ 1 + 2 + 5 + 5 + 2 + 0 + 3 + 1 + 5 + 4 + 5 ➝ 33
- Transform #2: 33 ➝ 3 + 3 ➝ 6
Thus the resulting integer is 6.


 */
