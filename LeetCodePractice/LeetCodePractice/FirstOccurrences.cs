using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class FirstOccurrences
    {
        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            int counter = 0;
            foreach(var item in haystack)
            {
                if (needle[counter] == item)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                    continue;
                }
                if (counter == needle.Length)
                {
                    index = haystack.IndexOf(needle);
                    return index;
                }
            }
            return -1;
        }
    }
}

/*
Definicion del problema:
Tenemos dos strings, dos palabras
se debe encontrar el index de la segunda palabra si tiene ocurrencia en la primera
si no tiene se devuelve -1


Estrategia:
haystack = "sadbutsadsa", needle = "sad"

casos especiales:
haystack = "sdbutsad", needle = "sad"

haystack = "sdbutsa", needle = "sad"


Hagarramos la primera letra de needle y buscamos su igualdad en haystack
si hay igualdad seguimos con la segunda letra de needle hasta completar y ver si realmente needle tiene ocurrencia en haystack
si no tiene ninguna igualdad o needle no se completa entonces devolvemos -1

 */
