using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : IShape
    {
        double @base, height;
        double sideA, sideB, sideC;
        public Triangle()
        {
            @base = 0.0;
            height = 0.0;
        }
        public Triangle(double baseLength, double height)
        {
            this.@base = baseLength;
            this.height = height;

        }
        public Triangle(double sideA,double sideB,double sideC)
        {

            double s = (sideA + sideB + sideC) / 2;
            this.@base = Math.Sqrt(s * (s - sideA)) * 2;
            this.height = Math.Sqrt((s - sideB) * (s - sideC));
        }

        public double CalculateArea()
        {
            return (0.5 * @base * height);
        }

    }
}
