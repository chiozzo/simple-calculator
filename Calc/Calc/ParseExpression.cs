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

        public object[] ParseExpression(string userExpression, Stack stack)
        {
            int operandIndex = userExpression.IndexOfAny(new char[] { '+', '-', '*', '/', '%', '=' }, 1);
            if (operandIndex == -1)
            {
                throw new ArgumentException("You didn't provide a valid operator.");
            }
            char operand = userExpression[operandIndex];
            string[] terms = userExpression.Split(operand);

            if (terms.Length > 2)
            {
                throw new ArgumentException("Your expression has too many parts.");
            }

            if (operand == '=')
            {
                object[] assignedConstant = stack.SetConstant(userExpression, terms);
                return new object[] { assignedConstant[0], operand, assignedConstant[1] };
            }
            else
            {
                // It seems this condition is always true. What is going on here? Is terms[1] == "" when "5+" is provided?
                if (terms.Length != 2)
                {
                    throw new ArgumentException("You didn't provide enough terms for me to calculate.");
                }

                int term1;
                bool success = int.TryParse(terms[0], out term1);
                if (!success)
                {
                    char constantLookup = char.ToUpper(terms[0][0]);
                    term1 = stack.GetConstantValue(constantLookup);
                    if (term1 == 0)
                    {
                        throw new ArgumentException("Your first term is not a valid integer.");
                    }
                }
                int term2;
                success = int.TryParse(terms[1], out term2);
                if (!success)
                {
                    throw new ArgumentException("Your second term is not a valid integer.");
                }
                object[] lastExpression = { term1, operand, term2 };
                stack.lastQ = lastExpression;
                return new object[] { term1, operand, term2 };
            }
        }
    }
}