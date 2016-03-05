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
            Console.Write("[0]> ");
            string userExpressionString = Console.ReadLine();
            Expression parse = new Expression();
            object[] userExpressionObject = parse.ParseExpression(userExpressionString);
            Operations math = new Operations();
            Console.WriteLine("   = {0}", math.DoMath(userExpressionObject));
            Console.ReadKey();
        }
    }
}