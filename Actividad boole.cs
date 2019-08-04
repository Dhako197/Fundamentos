using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_boole
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
            int diferencia = a - b;
            if (diferencia < 0) diferencia = diferencia * (-1);

            bool condi1 = votosTotales > n;
            bool condi2 = diferencia < (votosTotales * 0.1);
            bool condi3 = votosTotales < (n * 0.3);

            if ( condi1 || (condi2 && condi3))
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas otra vez");
            }
            else
            {
                if (a > b) Console.WriteLine("Ganador partido A");
                else if (a == b) Console.WriteLine("Empate en votos");
                else Console.WriteLine("Gana partido B");
            }

        }

    }
}
