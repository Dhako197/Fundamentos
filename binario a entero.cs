using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar valores binarios max 5");

            int b4 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b0 = int.Parse(Console.ReadLine());

            double b0c = b0 * Math.Pow(2, 0);
            double b1c = b1 * Math.Pow(2, 1);
            double b2c = b2 * Math.Pow(2, 2);
            double b3c = b3 * Math.Pow(2, 3);
            double b4c = b4 * Math.Pow(2, 4);

            double resultaldo = b0c + b1c + b2c + b3c + b4c;

            Console.WriteLine("numero entero: "+ resultaldo);
        }
    }
}
