using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Terminal
    {
        public Operations math = new Operations();
        public int counter { get; set; }

        public Terminal()
        {
            counter = 0;
        }

        public int IncrementExpressionCounter()
        {
            counter++;
            return counter;
        }

        public string PromptForExpression()
        {
            return String.Format("[{0}]> ", counter);
        }

        public string ReturnExpressionAnswer(double answer)
        {
            string ans = String.Format("   = {0}", answer);
            counter++;
            return ans;
        }

        public string ReturnLastExpressionString()
        {
            return string.Format("{0}{1}{2}", math.GetLastQ());
        }

        public object[] ReturnLastExpressionObject()
        {
            return math.GetLastQ();
        }
    }
}
