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
            while (true)
            {
                Console.WriteLine(prompt.PromptForExpression());
                string userExpressionString = Console.ReadLine();
                object[] userExpressionObject;
                if (userExpressionString == "lastq")
                {
                    userExpressionObject = prompt.ReturnLastExpressionObject();
                    Console.Write(prompt.ReturnLastExpressionString());
                } else
                {
                    userExpressionObject = parse.ParseExpression(userExpressionString);
                }

                double answer;
                if (userExpressionObject[0] != typeof(int))
                {
                    userExpressionObject[0] = math.GetConstant((char)userExpressionObject[0]);
                }
                answer = prompt.math.DoMath(userExpressionObject);

                Console.WriteLine(prompt.ReturnExpressionAnswer(answer));
            }
        }
    }
}