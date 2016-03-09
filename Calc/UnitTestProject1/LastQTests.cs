using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class LastQTests
    {
        [TestMethod]
        public void ProveRetrieveLastQ()
        {
            // Arrange
            Stack lastQ = new Stack();
            lastQ.SetLastQ(new object[] { 5, '+', 7});
            // Act
            object[] actual = { 5, '+', 7 };
            object[] expected = lastQ.GetLastQ();
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveSavedOnDoMath()
        {
            // Arrange
            Operations lastQ = new Operations();
            object[] testExpression = { 7, '+', 93 };
            // Act
            lastQ.DoMath(testExpression);
            object[] expected = testExpression;
            object[] actual = lastQ.GetLastQ();
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
