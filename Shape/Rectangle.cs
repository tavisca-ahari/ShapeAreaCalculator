using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : IShape
    {
        double length, breadth;
        public Rectangle()
        {
            length = 0.0;
            breadth = 0.0;
        }
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;

        }

        public double CalculateArea()
        {
            return (length * breadth);
        }
    }
}
