using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLib;
namespace ShapeLibTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Radius2_ReturnsArea()
        {
            var circle = new Circle(2);
            double expected = Math.PI * 2 * 2;

            var result = circle.Area();

            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_NegativeRadius_ThrowsException()
        {
            var circle = new Circle(-2);
        }
    }
}
