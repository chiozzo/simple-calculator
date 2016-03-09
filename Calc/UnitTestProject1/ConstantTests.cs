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

            // Assert

        }
    }
}
