using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Stack
    {
        public object[] lastQ { get; private set; }

        public object[] GetLastQ()
        {
            return lastQ;
        }

        public void SetLastQ(object[] expressionObject)
        {
            lastQ = expressionObject;
        }
    }
}
