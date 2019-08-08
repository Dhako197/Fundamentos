using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_y_minino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de datos: ");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int menor = 1000;
            string nombreMayor = "";
            string nombreMenor = "";
            while (contador < datos)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Nombre:");
                string nombre = Console.ReadLine();
                if (edad > maximo)
                {
                    maximo = edad;
                    nombreMayor = nombre;

                }
                if (edad < menor)
                {
                    menor = edad;
                   nombreMenor = nombre;
                }
                total += edad;
                contador += 1;
            }

            double promedio = total / contador;
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Nombre del mayor :" + nombreMayor);
            Console.WriteLine("Edad del mayor: " + maximo);
            Console.WriteLine("Nombre del menor: " + nombreMenor);
            Console.WriteLine("Edad del menor: " + menor);
        }
    }
}
