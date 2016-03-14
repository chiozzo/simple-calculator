using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;

namespace CalcTest
{
    [TestClass]
    public class TerminalTests
    {
        public int MyProperty { get; set; }
        [TestMethod]
        public void UIPathLastQuestion()
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

            // Assert
            Assert.AreEqual(stack.lastQ, testLastQ);
            /*
            Move to line 67
                Assert.AreEqual(response, "5+5");
            */
        }

        [TestMethod]
        public void UIPathLastAnswer()
        {
            // Arrange
            Expression parse = new Expression();
            Terminal prompt = new Terminal();
            Operations math = new Operations();
            Stack stack = new Stack();
            object[] testLastQ = { 5, '+', 5 };
            double testLastA = 10;
            stack.SetLastQ(testLastQ);

            // Act
            string userInput = "last";
            RunProgram(userInput, prompt, parse, math, stack);

            // Assert
            Assert.AreEqual(stack.lastQ, testLastQ);
            Assert.AreEqual(math.DoMath(testLastQ), testLastA);
            /*
            Move to line 67
                Assert.AreEqual("5+5   = 10", response);
            */
        }

        public static void RunProgram(string userInput, Terminal prompt, Expression parse, Operations math, Stack stack)
        {
            object[] userExpressionObject;
            if (userInput == "lastq" || userInput == "last")
            {
                userExpressionObject = stack.lastQ;
                string response;
                response = prompt.ReturnLastExpressionString(stack);
                if (userInput == "last")
                {
                    response = string.Format(response + prompt.ReturnExpressionAnswer(math.DoMath(userExpressionObject)));
                }
                Console.WriteLine(response);
            }
            else if (userInput == "exit" || userInput == "quit")
            {
                throw new Exception("Help, I can't get out!");
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
            Console.WriteLine(prompt.ReturnExpressionAnswer(answer));
        }
    }
}
