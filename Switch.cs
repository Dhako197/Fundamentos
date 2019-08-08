using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            double smmlv = 828116;
            double eps = 0;
            double arl = 0;
            double pension = 0;
            double bonificacion = 0;

            Console.WriteLine("Ingrese valor del salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de contrato (1) dependiente (2) independiente");
            int contrato = int.Parse(Console.ReadLine());

            double baseCotizacion = 0.4 * salario;
            if (baseCotizacion < smmlv) baseCotizacion = smmlv;

            switch (contrato)
            {
                case 1:
                    eps = 0.04 * baseCotizacion;
                    pension = 0.04 * baseCotizacion;
                    bonificacion = salario;
                    break;

                case 2:
                    eps = 0.125 * baseCotizacion;
                    pension = 0.16 * baseCotizacion;
                    Console.WriteLine("Ingrese valor de riesgo laboral (1-5)");
                    int riesgo = int.Parse(Console.ReadLine());

                    switch (riesgo)
                    {
                        case 1: arl = 0.5522;
                            break;
                        case 2: arl = 1.044;
                            break;
                        case 3: arl = 2.436;
                            break;
                        case 4: arl = 4.350;
                            break;
                        case 5: arl = 6.960;
                            break;

                    }
                    break;

                   

            }

            double salarioReal = salario - pension - eps - arl;
            Console.WriteLine("Salario real:" + salarioReal);
            double salarioAnual = (salario * 12) + bonificacion;
            Console.WriteLine("Salario anual:" + salarioAnual);

        }
    }
}
