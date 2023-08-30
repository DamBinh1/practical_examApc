using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Ex1
{
    public class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }

        public void Process(double radius, double height)
        {
            Radius = radius;
            Height = height;

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public string Result()
        {
            return $"Cylinder Characteristics:\n" +
                   $"Radius: {Radius}  ; " + $"Height: {Radius}\n" +
                   $"Base: {BaseArea:F2} ; " +
                   $"Lateral: {LateralArea:F2} ; " +
                   $"Total: {TotalArea:F2} ; " +
                   $"Volume: {Volume:F2}";
        }
    }
}

