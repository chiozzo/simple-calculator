using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calc
{
    public class Expression
    {
        public char[] operands { get; set; }

       public object[] ParseExpression(string userExpression)
        {
            string userExpressionString = userExpression.Replace(" ", "");
            int operandIndex = userExpressionString.IndexOfAny(new char[] { '+', '-', '*', '/', '%' });
            char operand = userExpressionString[operandIndex];
            string[] terms = userExpression.Split(operand);
            int term1 = Convert.ToInt32(terms[0]);
            int term2 = Convert.ToInt32(terms[1]);
            object[] parsedExpression = { term1, operand, term2 };
            return parsedExpression;
        }
    }
}