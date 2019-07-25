using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese IMC");
            double imc = double.Parse(Console.ReadLine());

            if (imc <= 18.5)
            {
                Console.WriteLine("Esta bajo de peso");
            }

            else if (18.5<= imc && imc <=24.9)
            {
                Console.WriteLine("Esta en un peso ideal");
            }

            else if (25.0<= imc && imc <=29.9)
            {
                Console.WriteLine("Esta en sobrepeso");
            }

            else 
            {
                Console.WriteLine("Esta en obesidad");
            }
        }                           
    }
}
