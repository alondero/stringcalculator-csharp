﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using StringCalculator;
using FluentAssertions;
using FakeItEasy;

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

        [Fact]
        public void SupportsCustomDelimiters()
        {
            calc.Add("//a\n1a2a3").Should().Be(6);
        }

        [Fact]
        public void ThrowsExceptionIfNegativeNumberFound()
        {
            Action act = () => calc.Add("-1");

            act.ShouldThrow<NegativeNumberException>();
        }

        [Fact]
        public void ContainsAllNegativeNumbersInExceptionMessage()
        {
            Action act = () => calc.Add("-8,-7,-6,5,4,-3");

            act.ShouldThrow<NegativeNumberException>().WithMessage("*-8*-7*-6*-3");
        }

        [Fact]
        public void FilterNumbersGreaterThan1000()
        {
            calc.Add("2,1000,1005").Should().Be(1002);
        }
    }

}
