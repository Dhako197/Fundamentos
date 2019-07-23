using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos de Y y Z");
            double rectay = double.Parse(Console.ReadLine());
            double rectaz = double.Parse(Console.ReadLine());

            double t = Math.Sqrt((rectay * rectay) + (rectaz * rectaz));
            double anguloc = Math.Acos(rectay/t);
            double anguloa = Math.Acos(rectaz/t);

            double aAnguloGrados = anguloa * (180 / Math.PI);
            double cAnguloGrados = anguloc * (180 / Math.PI);

            Console.WriteLine("t: " + t);
            Console.WriteLine("Angulo c: " + cAnguloGrados);
            Console.WriteLine("Angulo a: " + aAnguloGrados);
            

        }
    }
}
