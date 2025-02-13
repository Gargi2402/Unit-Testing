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

        //Test case 1: First two sides are equal
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case1()
        {
            // Arrange
            int side1 = 15, side2 = 15, side3 = 24;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        //Test Case 2: Last two sides are equal
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case2()
        {
            // Arrange
            int side1 = 24, side2 = 66, side3 = 66;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        //Test Case 3: First and last sides are equal
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case3()
        {
            // Arrange
            int side1 = 10, side2 = 5, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }
    }
}
