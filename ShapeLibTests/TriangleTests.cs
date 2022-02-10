using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLib;
namespace ShapeLibTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Area_3and4and5_Returns6()
        {
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;

            var result = triangle.Area();

            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Triangle_IsNotRight_ReturnsTrue()
        {
            var triangle = new Triangle(6, 9, 14);

            var result = triangle.IsRight();

            Assert.IsFalse(result);

        }
    }
}
