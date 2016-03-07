using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Operations : LastExpression
    {

        public double DoMath(object[] parsedExpression)
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

            SetLastQ(parsedExpression);

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

        public double Divide(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return (double)term1 / (double)term2;
        }

        public double Modulo(object[] parsedExpression)
        {
            int term1 = (int)parsedExpression[0];
            int term2 = (int)parsedExpression[2];
            return term1 % term2;
        }
    }
}
