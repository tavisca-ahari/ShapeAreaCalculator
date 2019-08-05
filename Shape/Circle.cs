using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle : IShape
    {
        double radius;
        public Circle()
        {
            radius = 0.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return (3.14 * radius * radius);
        }
    }
}
