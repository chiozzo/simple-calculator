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
        public int counter { get; set; }

        public Expression()
        {
            counter = 1;
        }
        public int IncrementExpressionCounter()
        {
            return counter++;
        }

        public object[] ParseExpression(string userExpression)
        {
            string userExpressionString = userExpression.Replace(" ", "");
            int operandIndex = userExpressionString.IndexOfAny(new char[] { '+', '-', '*', '/', '%' }, 1);

            if (operandIndex == -1)
            {
                throw new ArgumentException("You didn't provide a valid operator.");
            }
            char operand = userExpressionString[operandIndex];
            string[] terms = userExpression.Split(operand);
            // It seems this condition is always true. What is going on here? Is terms[1] == "" when "5+" is provided?
            if (terms.Length != 2)
            {
                throw new ArgumentException("You didn't provide enough terms for me to calculate.");
            }

            int term1;
            int term2;

            try
            {
                term1 = Convert.ToInt32(terms[0]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Your first term is not a valid integer.");
            }

            try
            {
                term2 = Convert.ToInt32(terms[1]);
            }
            catch (Exception)
            {
                throw new ArgumentException("Your second term is not a valid integer.");
            }

            object[] parsedExpression = { term1, operand, term2 };
            return parsedExpression;
        }
    }
}