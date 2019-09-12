using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();
            string[] valores = { "-", "-", "O", "X" };
            int n = 10;
            int m = 15;

            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for (int i=0; i<tablero.GetLength(0); i++)
            {
                for (int j=0; j< tablero.GetLength(1); j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }


            Console.WriteLine("ENTRADA: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("|" + tablero[i, j]);     
                }
                Console.Write("|\n");
            }

            Console.WriteLine("SALIDA: ");

            
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    for (int k= 0; k< tablero.GetLength(1)-3; k++)
                    {
                        if ( tablero[i, j] == valores[3] && tablero[i,j]== tablero[i+1,j] && tablero[i, j] == tablero[i + 2, j] )
                        {
                            Console.Write("|" + "1");
                            break;
                        }
                        else Console.Write("|" + salida[i, j]); break;
                       
                    }                   
                    //Console.Write("|" + salida[i, j]);
                }
                Console.Write("|\n");
            }
            Console.Write("\n");

        }
    }
}
