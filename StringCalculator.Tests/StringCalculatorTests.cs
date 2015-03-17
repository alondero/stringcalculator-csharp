using System;
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
        [Fact]
        public void Returns0WhenEmptyString()
        {
            StringCalculator calc = new StringCalculator();
            calc.add("").Should().Be(0);      
        }
    }
}
