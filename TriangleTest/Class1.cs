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

        //Test Case 1: Basic Scalene Triangle
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case1()
        {
            // Arrange
            int side1 = 3, side2 = 4, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        //Test Case 2: Larger Scalene Triangle
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case2()
        {
            // Arrange
            int side1 = 24, side2 = 15, side3 = 35;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        //Test Case 3: Another Valid Scalene Triangle
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case3()
        {
            // Arrange
            int side1 = 8, side2 = 6, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        //Test Case 4: Edge Case with Smallest Possible Scalene Triangle
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case4()
        {
            // Arrange
            int side1 = 2, side2 = 3, side3 = 4;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        //Test Case 5: Scalene Triangle with Large Numbers
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case5()
        {
            // Arrange
            int side1 = 65, side2 = 78, side3 = 90;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }
    }
}
