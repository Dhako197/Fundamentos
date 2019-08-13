using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int otraCarta;
            string continuar = "s";
            Console.WriteLine("Primera carta: " + carta1);
            Console.WriteLine("Segunda carta: " + carta2);
            int total = carta1 + carta2;
            Console.WriteLine("Total: " + total);

            Console.WriteLine("Desea otra carta? (s/n)");
            continuar = Console.ReadLine();

            while (continuar=="s" && total < 21)
            {
                otraCarta = aleatorio.Next(1, 11);
                Console.WriteLine("Nueva carta:" + otraCarta);
                total += otraCarta;
                if (total <= 21)
                {
                    Console.WriteLine("Nuevo total:" + total);
                    Console.WriteLine("Desea otra carta? (s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Has perdido");
                }
            }

            Console.WriteLine("Tu total final:" + total);

        }
    }
}
