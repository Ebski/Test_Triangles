using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Triangle_Excersize_1;

namespace Triangle_Excersize_Test
{
    [TestClass]
    public class GenerateTriangleTest
    {
        [TestMethod]
        public void notATriangle1()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 10;
            int b = 2;
            int c = 2;

            Assert.AreEqual(g.generate(a, b, c), "Not a triangle");
        }
        [TestMethod]
        public void notATriangle2()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = 10;
            int c = 2;

            Assert.AreEqual(g.generate(a, b, c), "Not a triangle");
        }
        [TestMethod]
        public void notATriangle3()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = 2;
            int c = 10;
            
            Assert.AreEqual(g.generate(a, b, c), "Not a triangle");
        }
        [TestMethod]
        public void equilateralTriangle()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 3;
            int b = 3;
            int c = 3;
            Assert.AreEqual(g.generate(a, b, c), "Equilateral triangle");
        }
        [TestMethod]
        public void isoscelesTriangle1()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 6;
            int b = 4;
            int c = 4;
            Assert.AreEqual(g.generate(a, b, c), "Isosceles triangle");
        }
        [TestMethod]
        public void isoscelesTriangle2()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 4;
            int b = 6;
            int c = 4;
            Assert.AreEqual(g.generate(a, b, c), "Isosceles triangle");
        }
        [TestMethod]
        public void isoscelesTriangle3()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 4;
            int b = 4;
            int c = 6;
            Assert.AreEqual(g.generate(a, b, c), "Isosceles triangle");
        }
        [TestMethod]
        public void scaleneTriangle()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 3;
            int b = 4;
            int c = 5;
            Assert.AreEqual(g.generate(a, b, c), "Scalene triangle");
        }
        [TestMethod]
        public void testZero1()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 0;
            int b = 2;
            int c = 2;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
        [TestMethod]
        public void testZero2()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = 0;
            int c = 2;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
        [TestMethod]
        public void testZero3()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = 2;
            int c = 0;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
        [TestMethod]
        public void testMinusNumber1()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = -1;
            int b = 2;
            int c = 2;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
        [TestMethod]
        public void testMinusNumber2()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = -1;
            int c = 2;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
        [TestMethod]
        public void testMinusNumber3()
        {
            GenerateTriangle g = new GenerateTriangle();
            int a = 2;
            int b = 2;
            int c = -1;
            Assert.AreEqual(g.generate(a, b, c), "Invalid input");
        }
    }
}
