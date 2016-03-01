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
    }
}