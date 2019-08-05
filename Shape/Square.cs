using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square : IShape
    {
        double side;
        public Square()
        {
            side = 0.0;
        }
        public Square(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return (side * side);
        }
    }
}
