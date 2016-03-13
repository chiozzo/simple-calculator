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
                Console.WriteLine(prompt.PromptForExpression());
                string userExpressionString = Console.ReadLine();
                object[] userExpressionObject;
                if (userExpressionString == "lastq")
                {
                    userExpressionObject = prompt.ReturnLastExpressionObject(stack);
                    Console.Write(prompt.ReturnLastExpressionString(stack));
                } else
                {
                    userExpressionObject = parse.ParseExpression(userExpressionString, stack);
                }

                double answer;
                if (userExpressionObject[0] is int)
                {
                    userExpressionObject[0] = stack.GetConstant((char)userExpressionObject[0]);
                }
                answer = math.DoMath(userExpressionObject, stack);

                Console.WriteLine(prompt.ReturnExpressionAnswer(answer));
            }
        }
    }
}