using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_cuota_moderada2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su salario mensual:");
            Double sal = Double.Parse(Console.ReadLine());
            Double smmlv = 828116;

            if (sal< smmlv*2)
            {
                Console.WriteLine("Paga tarifa A.");
                Console.WriteLine("Valor de cuota moderadora: $3200");
            }

            else if ((smmlv*2) <= sal && sal <=(smmlv *5))
            {
                Console.WriteLine("Paga tarifa B");
                Console.WriteLine("Valor de cuota moderadora: $12700 ");
            }

            else
            {
                Console.WriteLine("Paga tarifa C");
                Console.WriteLine("Valor de cuota moderadora: $33500");
            }
        }
    }
}
