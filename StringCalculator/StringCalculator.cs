using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace StringCalculator
{
    public class StringCalculator
    {
        private readonly IEnumerable<char> _delimiters = new char[] { ',', '\n' };

        // Adds any digits it finds in the input string, providing the answer as an integer
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
            }

            IEnumerable<int> numbers = Tokenise(input)
                    .Select(token => Convert.ToInt32(token));

            if (numbers.Min() < 0) {
                throw new NegativeNumberException(numbers.Where(number => number < 0));
            }

            return numbers
                .Sum();
        }

        private string[] Tokenise(string input)
        {
            IList<char> delimiters = _delimiters.ToList();

            if (input.StartsWith("//")) 
            {
                delimiters.Add(input.Substring(2, 1)[0]);
                input = input.Substring(4);
                Debug.WriteLine(input);
            }
            
            return input.Split(delimiters.ToArray());
        }
    }
}
