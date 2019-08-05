using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shape;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void TestCircle()
        {
            Circle circle= new Circle(5);
            Assert.AreEqual(78.5, Math.Round(circle.CalculateArea(),1));


        }
   

        [TestMethod]
        public void TestSquare()
        {
            Square square= new Square(5);
            Assert.AreEqual(25,square.CalculateArea());


        }

        [TestMethod]
        public void TestRectangle()
        {
            Rectangle rectangle= new Rectangle(5,10);
            Assert.AreEqual(50,rectangle.CalculateArea());


        }

        [TestMethod]
        public void TestTriangleWithBaseAndHeight()
        {
            Triangle triangle = new Triangle(5, 10);
            Assert.AreEqual(25, triangle.CalculateArea());
        }

        [TestMethod]
        public void TestTriangleWithThreeSides()
        {
            Triangle triangle = new Triangle(3,4,5);
            Assert.AreEqual(6, triangle.CalculateArea());
        }

    }
}
