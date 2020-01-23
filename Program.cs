using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {

            bool esNumero;
            int opt;
            int[] miVector = null;

            do
            {
                mostrarMenu();
                do
                {
                    Console.WriteLine("Ingrese una opcion");
                    esNumero = int.TryParse(Console.ReadLine(), out opt);
                } while (!esNumero);

                switch (opt)
                {
                    case 0: //salir
                        Console.WriteLine("Chao");
                        break;

                    case 1: //Ingresar valor
                        miVector = ingresarDatos();
                        break;

                    case 2: // ordeanr datos
                        break;

                    case 3: // Buscar numero
                        break;

                    case 4: // Remplazar elemto
                        break;

                    default:
                        Console.WriteLine("Oh, algo salio mal");
                        break;

                }



            } while (opt != 0);


        }

        public static void mostrarMenu()
        {
            Console.WriteLine(" Aplicacion de vectores");
            Console.WriteLine("0, Salir");
            Console.WriteLine("1, Ingresar datos del vector");
            Console.WriteLine("2, Ordenar datos");
            Console.WriteLine("3, Busacar numero en vector");
            Console.WriteLine("4, Remplazar un elemento");


        }
        // zona de subrutinas

        public static int[] ingresarDatos()
        {
            int[] miVector = new int[5];
            int nro = 0;
            bool esNumero = false;

            for (int i =0; i< 5; i++)
            {
                Console.WriteLine("Ingrese una valor para la posicion "+ i + ":" );
                esNumero = int.TryParse(Console.ReadLine(), out nro);
                if (esNumero)
                    miVector[i] = nro;
                else
                    miVector[i] = 0;

            }


            return miVector;
        }
    }
}
