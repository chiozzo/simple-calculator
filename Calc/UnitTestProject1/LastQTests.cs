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
            LastExpression lastQ= new LastExpression();
            lastQ.lastQ = "5 + 7";
            // Act
            string actual = "5 + 7";
            string expected = lastQ.lastQ;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
