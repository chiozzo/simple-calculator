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
            Expression userExpression = new Expression();
            string userInput = "5+6";
            Console.WriteLine(userExpression.GetTermsFromExpression(userInput));
        }
    }
}