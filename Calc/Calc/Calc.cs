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
                string userExpressionString = prompt.PromptForExpression();
                object[] userExpressionObject;
                if (userExpressionString == "lastq")
                {
                    userExpressionObject = math.GetLastQ();
                    string lastQString = String.Format("{0}{1}{2}", userExpressionObject[0], userExpressionObject[1], userExpressionObject[2]);
                    Console.Write(lastQString);
                    // need to console write userExpressionObject after conversion to string
                } else
                {
                    userExpressionObject = parse.ParseExpression(userExpressionString);
                }
                double answer = math.DoMath(userExpressionObject);
                Console.WriteLine(prompt.ReturnExpressionAnswer(answer));
            }
        }
    }
}