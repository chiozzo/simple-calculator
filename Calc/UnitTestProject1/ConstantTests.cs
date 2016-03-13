using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace UnitTestProject1
{
    [TestClass]
    public class ConstantTests
    {
        [TestMethod]
        public void ProveRetrieveLastQ()
        {
            // Arrange
            Stack stack = new Stack();
            stack.SetLastQ(new object[] { 5, '+', 7 });
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
            stack.SetLastQ(testExpression);
            int expected = 100;
            double actual = math.DoMath(stack.lastQ, stack);
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
            int actual = constant.GetConstant('C');
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
