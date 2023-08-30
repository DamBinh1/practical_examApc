
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Cylinder cylinder = new Cylinder();

            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            cylinder.Process(radius, height);
            Console.WriteLine(cylinder.Result());
            Console.WriteLine();
        }
    }
}
    

