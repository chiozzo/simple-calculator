using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class LastExpression
    {
        private object[] lastQ { get; set; }

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
