using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valores de t y a");
            double tHipotenusa = double.Parse(Console.ReadLine());
            double aAngulo = double.Parse(Console.ReadLine());

            double aAnguloRad = aAngulo * (Math.PI / 180.0);
           
            double aSenAngulo = Math.Sin(aAnguloRad);
            double aCosAngulo = Math.Cos(aAngulo);


            double zCateto = tHipotenusa * aCosAngulo;
            double cAngulo = Math.Asin(zCateto / tHipotenusa);
            double yCateto = tHipotenusa * aSenAngulo;

            
            double cAnguloGrados = cAngulo * (180 / Math.PI);
            


            Console.WriteLine("z: "+ zCateto);
            Console.WriteLine("c: "+ cAnguloGrados);
            Console.WriteLine("y: "+ yCateto);




        }
    }
}
