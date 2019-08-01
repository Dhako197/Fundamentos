using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de votos del partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de votos del partido2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero total de la poblacion de todas las edades");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Imgrese porcentaje(de 0 a 100%) de la poblacion que es mayor de edad");
            int p = int.Parse(Console.ReadLine());

            int votosTotales = a + b + blancos + anulados;
            int abstencion =  (((p * n)/100)) - (votosTotales);
            Console.WriteLine("abstencion: " + abstencion);

            bool anu30 = anulados < (0.30 * (a + b));
            bool blancoMenor = (a + b) > blancos;
            bool absNoVotaron = votosTotales > abstencion;

            if ((anu30 || blancoMenor) && absNoVotaron)
            {
                if (a > b) Console.WriteLine("Ganadaor de las eleccion: A");
                else if (a == b) Console.WriteLine("Se van a segunda Vuelta");
                else Console.WriteLine("Ganador de las elecciones B");
            }
            else Console.WriteLine("Las elecciones deben repetirse");
      

        }
    }
}
