using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Stack
    {
        public object[] lastQ { get; set; }

        public Dictionary<char, int> constants = new Dictionary<char, int>();

        public int GetConstantValue(char constantLookup)
        {
            int constantValue = 0;
            if (!constants.ContainsKey(constantLookup))
            {
                if (!constants.TryGetValue(constantLookup, out constantValue))
                {
                    throw new ArgumentException("I could not retrieve the constant value.");
                }
                throw new ArgumentException("You have not saved that constant.");
            }
            return constantValue;
        }

        public object[] SetConstant(string userInput, string[] terms)
        {
            userInput = userInput.ToUpper();
            int constantIndex = userInput.IndexOfAny(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
            if (constantIndex == -1)
            {
                throw new ArgumentException("You didn't provide a valid letter for your constant.");
            }
            char constantUpper = char.ToUpper(userInput[constantIndex]);

            int term;
            bool success = int.TryParse(terms[1], out term);
            if (!success)
            {
                throw new ArgumentException("The term you're assigning is not a valid integer.");
            }

            constants.Add(constantUpper, term);
            return new object[] { constantUpper, term };
        }
    }
}
