using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        private readonly char[] _delimiters = { ',', '\n' };

        // Adds any digits it finds in the input string, providing the answer as an integer
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
            }

            return input
                    .Split(_delimiters)
                    .Sum(token => Convert.ToInt32(token));
        }
    }
}
