using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class TerminalTests
    {
        [TestMethod]
        public void UIPathLastQ()
        {
            // Arrange
            Expression parse = new Expression();
            Terminal prompt = new Terminal();
            Operations math = new Operations();
            Stack stack = new Stack();
            object[] testLastQ = { 5, '+', 5 };
            stack.SetLastQ(testLastQ);

            // Act
            string userInput = "lastq";
            RunProgram(userInput, prompt, parse, math, stack);

            Assert.AreEqual(stack.lastQ, testLastQ);
        }

        public static void RunProgram(string userInput, Terminal prompt, Expression parse, Operations math, Stack stack)
        {
            object[] userExpressionObject;
            if (userInput == "lastq")
            {
                userExpressionObject = prompt.ReturnLastExpressionObject(stack);
                Console.WriteLine(prompt.ReturnLastExpressionString(stack));
            }
            else
            {
                userExpressionObject = parse.ParseExpression(userInput, stack);
            }
            double answer;
            /*
            if (userExpressionObject[0] is int)
            {
                userExpressionObject[0] = stack.GetConstant((char)userExpressionObject[0]);
            }
            */
            answer = math.DoMath(userExpressionObject);
            userExpressionObject = prompt.ReturnLastExpressionObject(stack);
        }
    }
}
