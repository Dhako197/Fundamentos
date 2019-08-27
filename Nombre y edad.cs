using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edad_y_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de datos: ");
            int n = int.Parse(Console.ReadLine());

            int[] edades = new int[n];
            string[] nombres = new string[n];
            double[] distancia = new double[n];

            int max = 0;
            string maxN = "";

            int min = 1000;
            string minN = "";

            double total = 0;
            double promedio = 0;
            double sumatoria = 0;
            double cercano = 100000;
            string nombrCercano = "";


            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese edad: ");
                edades[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                total += edades[i];
                promedio = total / edades.Length;

                if (edades[i] > max)
                {
                    max = edades[i];
                    maxN = nombres[i];
                }
                if (edades[i] < min)
                {
                    min = edades[i];
                    minN = nombres[i];

                }

            }

            for (int i = 0; i < edades.Length; i++)
            {
                distancia[i] = Math.Pow((edades[i] - promedio), 2);
                sumatoria += distancia[i];

                double cerca = Math.Abs(promedio - edades[i] );
                if (cerca < cercano)
                {
                    nombrCercano = nombres[i];
                }


            }

            double desviacion = Math.Sqrt(sumatoria / edades.Length);



            Console.WriteLine("Mayor: " + maxN + " con " + max + " años");
            Console.WriteLine("Menor: " + minN + " con " + min + " años");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Desviacion: " + desviacion);
            Console.WriteLine("Persona con edad mas cercana al promedio: " + nombrCercano);



        }
    }
}
