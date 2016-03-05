using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System.Text.RegularExpressions;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void ProveInstantiateExpression()
        {
        // Arrange - Scenario Setup
        Expression parseExpression = new Expression();
        // Assert - Did it work as expected?
        Assert.IsNotNull(parseExpression);
        }

        [TestMethod]
        public void ProveExpressionParsed()
        {
            // Arrange - Scenario Setup
            Expression parseExpression = new Expression();
            string testExpressionSpace = "5 + 6";
            // Act - Do the thing you want to test
            object[] expected = { 5, '+', 6 };
            object[] actual = parseExpression.ParseExpression(testExpressionSpace);
            // Assert - Did it work as expected?
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionNotEnoughTerms()
        {
            Expression parseExpression = new Expression();
            string badTestExpression = "+2";
            parseExpression.ParseExpression(badTestExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionNotEnoughTermsWithLetter()
        {
            Expression parseExpression = new Expression();
            string badTestExpression = "x+2";
            parseExpression.ParseExpression(badTestExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionOutOfOrder()
        {
            Expression parseExpression = new Expression();
            string badTestExpression = "75 75 -";
            parseExpression.ParseExpression(badTestExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionEquals()
        {
            Expression parseExpression = new Expression();
            string badTestExpression = "6 = 9";
            parseExpression.ParseExpression(badTestExpression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionConstant()
        {
            Expression parseExpression = new Expression();
            string badTestExpression = "x = 7";
            parseExpression.ParseExpression(badTestExpression);
        }

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
//Ensure you have examples of GOOD and BAD input and have you Parse class throw an exception when there's an error.

//Your expression should work with and without spaces. (i.e.both 2+1 and 2 + 1 should work)
//The use of Regular Expressions is not required.
//GOOD input example: 1+2
//BAD input example +2
//You do not need to handle the cases of usage of parenthesis or expressions with more than 2 terms.
