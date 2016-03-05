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
        public object[] ParseExpression(string userExpression)
        {
            string userExpressionString = userExpression.Replace(" ", "");
            int operandIndex = userExpressionString.IndexOfAny(new char[] { '+', '-', '*', '/', '%' });
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

    public class Operations
    {
        public int DoMath(object[] parsedExpression)
        {
            char operand;

            try
            {
                operand = (char)parsedExpression[1];
            }
            catch (Exception)
            {

                throw new InvalidCastException("Encountered a problem using your operand.");
            }

            if (operand == '+')
            {
                return Add(parsedExpression);
            }
            else if (operand == '-')
            {
                return Subtract(parsedExpression);
            }
            else if (operand == '*')
            {
                return Multiply(parsedExpression);
            }
            else if (operand == '/')
            {
                return Divide(parsedExpression);
            }
            else if (operand == '%')
            {
                return Modulo(parsedExpression);
            }
            return 0;
        }

        public int Add(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 + term2;
        }

        public int Subtract(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 - term2;
        }

        public int Multiply(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 * term2;
        }

        public int Divide(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 / term2;
        }

        public int Modulo(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 % term2;
        }
    }
}