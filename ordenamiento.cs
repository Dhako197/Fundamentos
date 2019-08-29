using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamienyto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letras = { "S", "L", "M", "k", "M" };
            int[] numeros = { 1, 2, 1, 4, 5 };


            for (int c = 0; c < letras.Length; c++) {
                for (int i = 0; i < letras.Length - 1; i++)
                {
                    int temporal = 0;
                    string tempo = "";
                    if (numeros[i] < numeros[i + 1])
                    {
                        temporal = numeros[i + 1];
                        tempo = letras[i + 1];
                        numeros[i + 1] = numeros[i];
                        numeros[i] = temporal;
                        letras[i + 1] = letras[i];
                        letras[i] = tempo;

                    }
                    // Console.WriteLine(numeros[i]);

                }


            }

            for (int i = 0; i < letras.Length; i++) {
                Console.WriteLine(numeros[i] + letras[i]);

            }
            
        }
    }
}
