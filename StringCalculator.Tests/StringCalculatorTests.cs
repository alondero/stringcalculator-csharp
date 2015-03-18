﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using StringCalculator;
using FluentAssertions;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        private StringCalculator calc;

        public StringCalculatorTests()
        {
            calc = new StringCalculator();
        }

        [Fact]
        public void Returns0WhenEmptyString()
        {
            calc.Add("").Should().Be(0);      
        }

        [Fact]
        public void ReturnsTheSingleNumberProvided()
        {
            calc.Add("2").Should().Be(2);
        }

        [Fact]
        public void ReturnsTheSumOfTwoDelimitedNumbers()
        {
            calc.Add("1,2").Should().Be(3);
        }

        [Fact]
        public void ReturnsTheSumOfMultipleNumbersDelimitedByNewLine()
        {
            calc.Add("7\n42").Should().Be(49);
        }
    }
}
