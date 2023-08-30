using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercise2.Ex2
{
    public class Program
    { 
        
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