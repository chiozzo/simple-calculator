using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Terminal
    {
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
            Console.Write("[{0}]> ", counter);
            string userExpressionString = Console.ReadLine();
            return userExpressionString;
        }

        public string ReturnExpressionAnswer(double answer)
        {
            string ans = String.Format("   = {0}", answer);
            counter++;
            return ans;
        }
    }
}
