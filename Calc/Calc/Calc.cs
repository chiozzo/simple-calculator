using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calc
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please give me a simple expression. I'm not a very good calculator.");
            Expression parse = new Expression();
            Terminal prompt = new Terminal();
            Operations math = new Operations();
            Stack stack = new Stack();
            while (true)
            {
                Console.Write(prompt.PromptForExpression());
                string userInput = Console.ReadLine().Replace(" ", "");
                RunProgram(userInput, prompt, parse, math, stack);
            }
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