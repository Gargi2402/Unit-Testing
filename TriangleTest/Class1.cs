using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleTest
{
    [TestFixture] // REQUIRED for NUnit
    public class Class1
    {
        [Test] // REQUIRED for each NUnit test
        public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 15, side2 = 15, side3 = 15;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }
    }
}
