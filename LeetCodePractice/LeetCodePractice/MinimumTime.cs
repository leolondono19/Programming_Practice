using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class MinimumTime
    {
        public int MinTimeToType(string word)
        {
            const int a = 97;
            int seconds = 0;
            int lastValue = a;
            int shortWay = 0;

            foreach (var item in word)
            {
                int rightCalculation = Math.Abs(((int)item - lastValue));
                int leftCalculation = Math.Abs((rightCalculation - 26));

                shortWay = Math.Min(rightCalculation, leftCalculation);
                seconds += (int)(shortWay + 1);

                lastValue = (int)item;
            }
            return seconds;
        }
    }
}



/*
ASCII VALUES a to z: 97 to 122. 
Input: word = "abc"
Output: 5
98 - 120
98 - 112
1 10 + 1

Input: word = "abp"


PROBLEMA:
Se tiene el abecedario completo, se debe contar los segundos que se tarda en escribir un string especifico
el movimiento de un caracter a otro es 1 segundo al igual que la escritura del mismo
Se deben contar los segundos basados en el camino mas rapido y en el tiempo minimo
Como saber el extremo mas cercano de un caracter

NOTAS:
La letra de inicio, comieza con un segundo, por escritura, no tiene segundo de movimiento


ESTRATEGIA:
Debemos usar el valor numerico ASCII de cada caracter para poder encontrar el camino mas corto y hacer el menor tiempo
Si es la primera letra automaticamente se le da 1 segundo por escritura y se continua a la siguiente
Se debe hacer una resta entre el valor ASCII de la letra actual con la ultima para obtener un resultado
Ese resultado en caso de ser positivo se multiplicara por 2 y sera el tiempo en segundos de una letra a otra
En caso de ser negativo se restara el valor actual y el anterior, cada uno con sus extremos mas cercanos
Se sumaran ambos resultados mas 1 y se multiplicara por 2 para obtener los segundos totales


   
111 o
distancia = 111-97 = 14

122 - 111 +1 = 12


Provar o = o(99) d(111)
(122 - 111 +1) +(99 - 97) = 14

o = origen   d=destination z = 122 a= 97

rightCalculation = (d-o) < 0 ? o-d : d-o
leftCalculation = (rightCalculation - 26) < 0 ? 26 - rightCalculation : rightCalculation - 26
Shortest-distance = Min(rightCalculation , (z - d +1) +(o - a) )
 */
