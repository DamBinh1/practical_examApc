using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practical_examApc.GeometryExample;
using practical_examApc.Exercise2;
namespace practical_examApc
{
    public class Program
    {/*
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

        */

        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");
            Animal[] animals = { tiger, lion };
            foreach (var animal in animals)
            {
                animal.Show();
                Console.WriteLine();
            }
        }
    }
}
