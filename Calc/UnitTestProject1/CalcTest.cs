using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System.Text.RegularExpressions;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        public string expression { get; set; }

        public CalcTest()
        {
            expression = "5 + 6";
        }

        [TestMethod]
        public void ProveInstantiateExpression()
        {
        // Arrange - Scenario Setup
        Expression userExpression = new Expression();
        // Assert - Did it work as expected?
        Assert.IsNotNull(userExpression);
        }

        [TestMethod]
        public void ProveSpacesAreRemoved()
        {
            // Arrange - Scenario Setup
            Expression userExpression = new Expression();
            // Act - Do the thing you want to test
            string expected = "5+6";
            string actual = userExpression.RemoveSpaceFromInput(expression);
            // Assert - Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveBothTermsAreExtracted()
        //Prove you can extract the terms of the expression.
        {
            // Arrange - Scenario Setup
            Expression userExpression = new Expression();
            string testExpression = "5+6";
            // Act - Do the thing you want to test
            char[] expected = { '5', '6' };
            char[] actual = { testExpression[0], testExpression[2] };
            // Assert - Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prove1stTermIsExtracted()
        {
            // Arrange - Scenario Setup
            Expression userExpression = new Expression();
            string testExpression = userExpression.RemoveSpaceFromInput(expression);
            // Regex rgx = new Regex("[+-/*]");
            // Act - Do the thing you want to test
            char expected = '5';
            char actual = testExpression[0];
            // Assert - Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProveOperationIsExtracted()
        //Prove you can extract the operation embedded in the expression.
        {
            // Arrange - Scenario Setup
            Expression userExpression = new Expression();
            string testExpression = userExpression.RemoveSpaceFromInput(expression);
            // Act - Do the thing you want to test
            char expected = '+';
            char actual = testExpression[1];
            // Assert - Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prove2ndTermIsExtracted()
        {
            // Arrange - Scenario Setup
            Expression userExpression = new Expression();
            string testExpression = userExpression.RemoveSpaceFromInput(expression);
            // Act - Do the thing you want to test
            char expected = '6';
            char actual = testExpression[2];
            // Assert - Did it work as expected?
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
