using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 7);
            int dado2 = aleatorio.Next(1, 7);
            string continuar = "s";
            int total = dado1 + dado2;
            int contador = 0;
            double contadorMas6 = 0;
            int contadorPar = 0;

            Console.WriteLine("Dado 1:" + dado1);
            Console.WriteLine("Dado 2:" + dado2);
            Console.WriteLine("Total:" + total);

            Console.WriteLine("Desea continuar? s/n");
            continuar = Console.ReadLine();


            while ((continuar == "s" && total<100) )
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);

                total += dado1 + dado2;
                contador += 1;
                //Console.WriteLine("Contador: " + contador);
                //Console.WriteLine("Contador mayor a 6: " + contadorMas6);
                //Console.WriteLine("Contador Par: " + contadorPar);

                if ((dado1 + dado2) > 6) contadorMas6 += 1;
                if ((dado1 == dado2)) contadorPar += 1;
                if(dado1==1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Dado 1:" + dado1);
                    Console.WriteLine("Dado 2:" + dado2);
                    Console.WriteLine("Total:" + total);
                    Console.WriteLine("Eliminado por 1 par");
                    break;
                }
                if (contadorPar == 3 || total >= 100) {
                    Console.WriteLine("Ganador!!!");
                    break;
                }

                Console.WriteLine("Dado 1:" + dado1);
                Console.WriteLine("Dado 2:" + dado2);
                Console.WriteLine("Total:" + total);

                Console.WriteLine("Desea continuar? s/n");
                continuar = Console.ReadLine();

            }

            Console.WriteLine("Total final:" + total);
            double prob = (contadorMas6 / contador) * 100;
            Console.WriteLine("Probabilidad +6: " + prob);



        }
    }
}
