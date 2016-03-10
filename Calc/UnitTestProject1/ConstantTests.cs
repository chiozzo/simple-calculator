using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace UnitTestProject1
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ProveConstantSaved()
        {
            // Arrange
            Operations constant = new Operations();
            object[] testExpression = { 'x', '=', 5 };
            // Act
            double actual = constant.DoMath(testExpression);
            int expected = 5;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveGetConstant()
        {
            // Arrange
            Operations constant = new Operations();
            object[] testExpression = { 'c', '=', 42 };
            // Act
            constant.DoMath(testExpression);
            int expected = 42;
            int actual = constant.GetConstant('C');
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
