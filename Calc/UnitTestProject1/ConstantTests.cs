using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ProveRetrieveLastQ()
        {
            // Arrange
            Stack stack = new Stack();
            object[] testExpression = { 5, '+', 7 };
            stack.lastQ = testExpression;
            // Act
            object[] actual = { 5, '+', 7 };
            object[] expected = stack.lastQ;
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveLastQSavedOnParse()
        {
            // Arrange
            Stack stack = new Stack();
            Expression parse = new Expression();
            string testExpression = "7 + 93";
            // Act
            object[] expected = parse.ParseExpression(testExpression, stack);
            object[] actual = stack.lastQ;
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveAnswerFromLastQ()
        {
            // Arrange
            Stack stack = new Stack();
            Operations math = new Operations();
            object[] testExpression = { 7, '+', 93 };
            // Act
            stack.lastQ = testExpression;
            int expected = 100;
            double actual = math.DoMath(stack.lastQ);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveSetAndGetConstant()
        {
            // Arrange
            Expression parse = new Expression();
            Stack constant = new Stack();
            string testExpression = "c = 42";
            // Act
            parse.ParseExpression(testExpression, constant);
            int expected = 42;
            int actual;
            constant.constants.TryGetValue('C', out actual);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
