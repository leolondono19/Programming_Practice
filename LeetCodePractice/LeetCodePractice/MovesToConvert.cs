using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class MovesToConvert
    {
        public int MinimumMoves(string s)
        {
            int threeCharactersCounter = 0;
            int counter = 0;
            int result = 0;

            if (!s.Contains('X'))
            {
                return result;
            }
            /*
            while ((s.Length - s.IndexOf('X')) % 3 != 0)
            {
                s = s.Insert(s.Length, "O");
            }
            */

            for (int i = s.IndexOf('X'); i < s.Length; i++)
            {
                threeCharactersCounter++;
                if (s[i] == 'X')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, "O");
                    counter++;
                }
                if (threeCharactersCounter == 3)
                {
                    threeCharactersCounter = 0;
                    if (counter > 0)
                    {
                        result++;
                        counter = 0;
                        if (!s.Contains('X'))
                        {
                            return result;
                        }
                    }
                    if ((s.Length - s.IndexOf('X')) == 1)
                    {
                        i = s.IndexOf('X') - 3;
                        continue;
                    }
                    else if ((s.Length - s.IndexOf('X')) == 2)
                    {
                        i = s.IndexOf('X') - 2;
                        continue;
                    }
                    i = s.IndexOf('X') - 1;
                }
            }
            return result;
        }

        public int MinimumMoves2(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'X')
                {
                    continue;
                }
                else
                {
                    result++;
                    i += 2;
                }
            }
            return result;
        }
    }
}


/*
 * OOOOOXOXOXX0000X0000XXX0
 *      ^
 * XXOX
 *    
 * 
 * "XXXOO"
 * OOOXX
 * 
 OOOOOXOXOXX
(INDEXOF / 2) * 3

Encontrar la primera X
Reviso cada caracter hasta llegar a 3
si encuentro una X en el camino la reemplazo con O
Al terminar, llevamos el iterador una posicion adelante de donde empezo

 public int MinimumMoves(string s)
        {
            int threeCharactersCounter = 0;
            int counter = 0;
            int result = 0;
            //int size = s.Length - s.IndexOf('X');

            if (!s.Contains('X'))
            {
                return result;
            }
            while ((s.Length - s.IndexOf('X')) % 3 != 0)
            {
                s = s.Insert(s.Length, "O");
            }

            for (int i = s.IndexOf('X'); i < s.Length; i++)
            {
                threeCharactersCounter++;
                if (s[i] == 'X')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, "O");
                    counter++;
                }
                if (threeCharactersCounter == 3)
                {
                    threeCharactersCounter = 0;
                    if (counter > 0)
                    {
                        result++;
                        counter = 0;
                    }
                }
            }
            return result;
        }


 
 */
