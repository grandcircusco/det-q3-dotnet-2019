using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculatorTDD
{
    public class CalculatorTest
    {
        [Fact]
        public void AddZeroPlusOne()
        {
            int result = Calculator.AddNumbers(0, 1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void AddOnePlusOne()
        {
            int result = Calculator.AddNumbers(1, 1);
            Assert.Equal(2, result);
        }

        //Skip to something plus two
        [Fact]
        public void AddOnePlusTwo()
        {
            int result = Calculator.AddNumbers(1, 2);
            Assert.Equal(3, result);
        }


    }
}
