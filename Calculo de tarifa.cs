using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_calculo_de_tarifa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su salario:");
            double sal = double.Parse(Console.ReadLine());

            if (sal < 828116 * 2)
            {
                Console.WriteLine("Se paga tarifa A");
            }

            else if ((828116 * 2) <= sal && sal <=(828116 * 4))
            {
                Console.WriteLine("Se paga tarifa B");
            }

            else
            {
                Console.WriteLine("Paga tarifa c");
            } 

        }
    }
}
