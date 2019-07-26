using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestDemo
{
    public class UnitTestDemoTests
    {
        [Theory]
        [InlineData(2,3)]
        [InlineData(1,21)]
        [InlineData(7, 71)]
        [InlineData(435, 345)]
        [InlineData(245, 789)]
        public static void AddTwoNumbers(double x, double y)
        {
            double expected = x+y;
            double actual = Program.AddNumbers(x,y);

            Assert.Equal(expected, actual);
        }    
    }
}
