using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void ExpressionTest()
//Prove you can extract the terms of the expression.
//Prove you can extract the operation embedded in the expression.
//Ensure you have examples of GOOD and BAD input and have you Parse class throw an exception when there's an error.

//Your expression should work with and without spaces. (i.e.both 2+1 and 2 + 1 should work)
//The use of Regular Expressions is not required.
//GOOD input example: 1+2
//BAD input example +2
//You do not need to handle the cases of usage of parenthesis or expressions with more than 2 terms.
        {
        // Arrange - Scenario Setup
        Expression userExpression = new Expression();
        // Act - Do the thing you want to test
        
        // Assert - Did it work as expected?
            
        }
    }
}
