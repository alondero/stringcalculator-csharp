﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator
{
    public class NegativeNumberException: Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }

        public NegativeNumberException(IEnumerable<int> negativeNumbers)
            : base(string.Join(", ", negativeNumbers))
        {
        }
    }
}
