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

        public Dictionary<char, int> constants = new Dictionary<char, int>();

        public void SetLastQ(object[] expressionObject)
        {
            lastQ = expressionObject;
        }
    }
}
