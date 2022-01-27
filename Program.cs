using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
    class Program
    {
        delegate double MyDelegate(int r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Line;
            double D= myDelegate(2);
            myDelegate = Area;
    
            double S = myDelegate(2);
            myDelegate = Volume;

            double V = myDelegate(2);
            
            
            
            Console.WriteLine("Длина окружности равна {0:F2} Площадь круга равна {1:F2} Объём круга равен {2:F2}", D, S, V);
            Console.ReadKey();

        }
        static double Line(int r) => 2 * Math.PI * r;
        static double Area(int r) => Math.PI*Math.Pow(r, 2);
        static double Volume(int r) => 4/3 * Math.PI *Math.Pow( r, 3);
    }
}
