﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Terminal
    {
        public int counter { get; set; }

        public Terminal()
        {
            counter = 0;
        }

        public string PromptForExpression()
        {
            return String.Format("[{0}]> ", counter);
        }

        public string ReturnExpressionAnswer(double answer)
        {
            string stringAnswer = String.Format("   = {0}", answer);
            counter++;
            return stringAnswer;
        }

        public string ReturnLastExpressionString(Stack stack)
        {
            return string.Format("     {0}{1}{2}", stack.lastQ);
        }
    }
}
