using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valores de c y z");
            double cAngulo = double.Parse(Console.ReadLine());
            double zCateto = double.Parse(Console.ReadLine());

            double cAnguloRad = cAngulo * (Math.PI / 180.0);

            double tHipotenusa = zCateto / Math.Sin(cAnguloRad);
            double aAngulo = Math.Acos(zCateto / tHipotenusa);
            double yCateto = tHipotenusa * Math.Sin(aAngulo);

           
            double aAnguloGrad = aAngulo * (180.0 / Math.PI);
            

            Console.WriteLine("t: " + tHipotenusa);
            Console.WriteLine("a: " + aAnguloGrad);
            Console.WriteLine("y: " + yCateto);
        }
    }
}
