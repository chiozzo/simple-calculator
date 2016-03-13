using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void ProveAdd()
        {
            // Arrange
            Operations adder = new Operations();
            object[] testExpression = { 5, '+', 6 };
            // Act
            int expected = 11;
            double actual = adder.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveAddBig()
        {
            // Arrange
            Operations adder = new Operations();
            object[] testExpression = { 321, '+', 654 };
            // Act
            int expected = 975;
            double actual = adder.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveAddNegative()
        {
            // Arrange
            Operations adder = new Operations();
            object[] testExpression = { 321, '+', -322 };
            // Act
            int expected = -1;
            double actual = adder.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveSubtract()
        {
            // Arrange
            Operations subtracter = new Operations();
            object[] testExpression = { 5, '-', 6 };
            // Act
            int expected = -1;
            double actual = subtracter.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveSubtractNegative()
        {
            // Arrange
            Operations subtracter = new Operations();
            object[] testExpression = { -5, '-', 6 };
            // Act
            int expected = -11;
            double actual = subtracter.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveSubtractBig()
        {
            // Arrange
            Operations subtracter = new Operations();
            object[] testExpression = { 321, '-', 654 };
            // Act
            int expected = -333;
            double actual = subtracter.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveMultiply()
        {
            // Arrange
            Operations multiplier = new Operations();
            object[] testExpression = { 5, '*', 6 };
            // Act
            int expected = 30;
            double actual = multiplier.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveMultiplyBig()
        {
            // Arrange
            Operations multiplier = new Operations();
            object[] testExpression = { 321, '*', 654 };
            // Act
            int expected = 209934;
            double actual = multiplier.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveDivide()
        {
            // Arrange
            Operations divider = new Operations();
            object[] testExpression = { 5, '/', 6 };
            // Act
            // Why does this require that "expected" be of type double.
            double expected = 0.83333333333333333;
            double actual = divider.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveModulo()
        {
            // Arrange
            Operations moduloer = new Operations();
            object[] testExpression = { 5, '%', 6 };
            // Act
            int expected = 5;
            double actual = moduloer.DoMath(testExpression);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
