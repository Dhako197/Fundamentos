using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_vidas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = aleatorio.Next(1, 7);
            int dado2 = aleatorio.Next(1, 7);
            int vidas = 3;
            int puntos = 0;
            int pierdeVidas = 0;
            int dobles = 0;
            string continuar = "s";

            puntos += dado;
            pierdeVidas += 1;
            dobles += 1;


            Console.WriteLine("Dado: " + dado);
            Console.WriteLine("Puntos: " + puntos);
            Console.WriteLine("Vidas:" + vidas);

            Console.WriteLine("Desea continuar? S/N");
            continuar = Console.ReadLine();

            while (continuar== "s" && vidas> 0)
            {
                dado = aleatorio.Next(1, 7);

                pierdeVidas += 1;
                dobles += 1;

                puntos += dado;



                if (pierdeVidas == 2)
                {
                    vidas -= 1;
                    pierdeVidas = 0;
                        
                }

                if(dobles == 3)
                {
                    dado2 = aleatorio.Next(1, 7);
                    dobles = 0;
                    Console.WriteLine("Dado extra: " + dado2);
                    puntos += dado2;
                    if (dado == dado2) vidas += 1;
                }

                Console.WriteLine("Dado: " + dado);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Vidas:" + vidas);

                if (vidas == 0) break;

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadLine();

                

            }

            Console.WriteLine("Puntos finales: " + puntos);
            Console.WriteLine("Gracias por jugar");

        }
    }
}
