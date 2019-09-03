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
            Console.WriteLine("Ingrese frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Ingrese palabra a buscar");
            string palabra = Console.ReadLine();

            string fraseMayus = frase.ToUpper();
            string palabraMayus = palabra.ToUpper();
            int veces = 0;
           


            for (int i=0; i<fraseMayus.Length - palabraMayus.Length+1; i++)
            {
                string palabraBuscada = "";
                for (int j = 0; j < palabraMayus.Length; j++)
                {
                    palabraBuscada += fraseMayus[i+j];
                    //Console.Write(palabraBuscada);                   
                }
                if (palabraBuscada == palabraMayus)
                {
                    Console.WriteLine("Palabra encontrada en: " + i );
                    veces++;
                }


            }
            Console.WriteLine("Veces que se encontro: " + veces);
            
        }
    }
}
