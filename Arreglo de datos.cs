using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordsX = { 0, 2, 3, 7 };
            double[] coordsY = { 0, 1, 5, 6 };
            //double distaciaMayor = 0;

            

            double m1 = (coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]);
            double m2 = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            double m3 = (coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]);

            /*
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            */

            double intercep1 = (coordsY[0]) - (m1 * coordsX[0]);
            double intercep2 = (coordsY[1]) - (m2 * coordsX[1]);
            double intercep3 = (coordsY[2]) - (m3 * coordsX[2]);

            if (m1 == m2 && m2==m3 && intercep1== intercep2 && intercep2== intercep3) Console.WriteLine("Es una recta");                      
            else Console.WriteLine("No es una Recta");                         

            double d1 = Math.Sqrt(Math.Pow(coordsX[1] - coordsX[0], 2) + (Math.Pow(coordsY[1] - coordsY[0], 2)));
            double d2 = Math.Sqrt(Math.Pow(coordsX[2] - coordsX[1], 2) + (Math.Pow(coordsY[2] - coordsY[1], 2)));
            double d3 = Math.Sqrt(Math.Pow(coordsX[3] - coordsX[2], 2) + (Math.Pow(coordsY[3] - coordsY[2], 2)));

            if (d1 > d2 && d1 > d3) Console.WriteLine("Distancia mas larga: " + d1);
            else if (d2> d1 && d2 >d3) Console.WriteLine("Distancia mas larga: " + d2);
            else Console.WriteLine("Distancia mas larga: " + d3);


            //y-mx=b

        }
    }
}
