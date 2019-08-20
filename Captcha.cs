using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int valorA = aleatorio.Next(1, 11);
            int valorB = aleatorio.Next(1, 11);
            int valorCorrecto = valorA + valorB;
            int respuestas = 0;
            int intentos = 0;

            Console.WriteLine("Sume" + valorA + "+" + valorB );
            respuestas = int.Parse(Console.ReadLine());
            intentos++;

            while((valorCorrecto != respuestas) && intentos<3)
            {
                valorA = aleatorio.Next(1, 11);
                valorB = aleatorio.Next(1, 11);

                Console.WriteLine("Error, ingrese el valor correcto");
                Console.WriteLine("Sume" + valorA + "+" + valorB);
                respuestas = int.Parse(Console.ReadLine());
                intentos++;
                valorCorrecto = valorA + valorB;

                if (intentos > 3) break;
            }

            if (valorCorrecto == respuestas) Console.WriteLine("Iniciando programa...");
            else
            {
                Console.WriteLine("Supero numero de intentos");
            }


        }
    }
}
