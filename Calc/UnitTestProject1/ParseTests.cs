using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System.Text.RegularExpressions;

namespace CalcTest
{
    [TestClass]
    public class ParseTests
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
            Stack stack = new Stack();
            Expression parseExpression = new Expression();
            string testExpressionSpace = "5 + 6";
            // Act - Do the thing you want to test
            object[] expected = { 5, '+', 6 };
            object[] actual = parseExpression.ParseExpression(testExpressionSpace, stack);
            // Assert - Did it work as expected?
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionNotEnoughTerms()
        {
            Stack stack = new Stack();
            Expression parseExpression = new Expression();
            string badTestExpression = "+2";
            parseExpression.ParseExpression(badTestExpression, stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionNotEnoughTermsWithLetter()
        {
            Stack stack = new Stack();
            Expression parseExpression = new Expression();
            string badTestExpression = "x+2";
            parseExpression.ParseExpression(badTestExpression, stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionOutOfOrder()
        {
            Stack stack = new Stack();
            Expression parseExpression = new Expression();
            string badTestExpression = "75 75 -";
            parseExpression.ParseExpression(badTestExpression, stack);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ProveBadExpressionEquals()
        {
            Stack stack = new Stack();
            Expression parseExpression = new Expression();
            string badTestExpression = "6 = 9";
            parseExpression.ParseExpression(badTestExpression, stack);
        }
    }
}
//Ensure you have examples of GOOD and BAD input and have you Parse class throw an exception when there's an error.

//Your expression should work with and without spaces. (i.e.both 2+1 and 2 + 1 should work)
//The use of Regular Expressions is not required.
//GOOD input example: 1+2
//BAD input example +2
//You do not need to handle the cases of usage of parenthesis or expressions with more than 2 terms.
