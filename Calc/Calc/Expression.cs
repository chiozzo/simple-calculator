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
        public string RemoveSpaceFromInput(string userExpression)
        {
            Regex rgx = new Regex("\\s+");
            string modifiedExpression = rgx.Replace(userExpression, "");
            // Is this the regex to look for spaces? /\s+/g
            return modifiedExpression;
        }

        public char[] GetTermsFromExpression(string userExpression)
        {
            char term1 = userExpression[0];
            char term2 = userExpression[2];
            return new char[] { term1, term2 };
        }
    }
}