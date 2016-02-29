using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Expression
    {
        public string userExpression { get; set; }
        public Expression()
        {
            userExpression = "5 + 6";
            userExpression.Replace(" ",""); // Is this the regex to look for spaces? /\s+/g
            Console.WriteLine(userExpression);
        }

    }
}