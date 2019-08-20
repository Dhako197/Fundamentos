using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 13);
            string continuar = "s";
            int contador = 0;
            int contadorGanador = 0;
            int total = dado1;

            Console.WriteLine("Tiro del dado: " + dado1);
            Console.WriteLine("Total: " + total);
            contador += 1;
            

            Console.WriteLine("Desea continuar? S/N");
            continuar = Console.ReadLine();

            while  (continuar=="s" && total < 100)
            {
                dado1 = aleatorio.Next(1, 13);
                total += dado1;
                contador += 1;
                Console.WriteLine("Tiro del dado: " + dado1);
                Console.WriteLine("Total: " + total);

                if (dado1 == 10) contadorGanador += 1;
                else if (dado1 == 12 && contadorGanador == 1)
                {
                    Console.WriteLine("Ha ganado");
                    Console.WriteLine("Total: " + total);
                    break;
                }
                else contadorGanador = 0;

                if (contador > 3 && (dado1 % 2 != 0))
                {
                    total = 0;

                    Console.WriteLine("Ha Perdido por q sacar impar");
                    
                    break;
                }

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadLine();


            }

            Console.WriteLine("Total final: " + total);

        }
    }
}
