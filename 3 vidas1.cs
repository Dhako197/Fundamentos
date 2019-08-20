using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3vidas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = aleatorio.Next(1, 7);
            int vidas = 3;
            int puntos = 0;
            int unos= 0;
            int seis = 0;
            string continuar = "s";

            puntos += dado;

            Console.WriteLine("Dado: "+ dado);
            Console.WriteLine("Puntos: " + puntos);
            Console.WriteLine("Vidas:" + vidas);

            Console.WriteLine("Desea continuar? S/N");
            continuar = Console.ReadLine();

            while (continuar=="s" && vidas > 0)
            {
                dado = aleatorio.Next(1, 7);
                puntos += dado;

                if (dado == 1)
                {
                    unos++;
                    if (unos == 2)
                    {
                        unos = 0;
                        vidas -= 1;
                        puntos -= 11;
                    }
                }

                if (dado == 6) seis += 1;
                else seis = 0;

                if (seis == 2 && vidas < 3) vidas += 1;

                Console.WriteLine("Dado: " + dado);
                Console.WriteLine("Puntos: " + puntos);
                Console.WriteLine("Vidas:" + vidas);

                Console.WriteLine("Desea continuar? S/N");
                continuar = Console.ReadLine();

                if (vidas == 0) break;
            }

            Console.WriteLine("Puntos finales: " + puntos);
            Console.WriteLine("Vidas:" + vidas);




        }
    }
}
