using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static FizzBuzzTDD.FizzBuzz;

namespace FizzBuzzTDD
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "Woof")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "Fizz")]
        [InlineData(14, "Woof")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "Woof")]
        [InlineData(18, "Fizz")]
        [InlineData(19, "19")]
        [InlineData(20, "Buzz")]
        [InlineData(21, "FizzWoof")]
        [InlineData(22, "22")]
        [InlineData(23, "Fizz")]
        [InlineData(24, "Fizz")]
        [InlineData(25, "Buzz")]
        [InlineData(26, "26")]
        [InlineData(27, "FizzWoof")]
        [InlineData(28, "Woof")]
        [InlineData(29, "29")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(31, "Fizz")]
        [InlineData(32, "Fizz")]
        [InlineData(33, "Fizz")]
        [InlineData(34, "Fizz")]
        [InlineData(35, "FizzBuzzWoof")]
        [InlineData(36, "Fizz")]
        [InlineData(37, "FizzWoof")]
        [InlineData(38, "Fizz")]
        [InlineData(39, "Fizz")]
        [InlineData(40, "Buzz")]
        [InlineData(41, "41")]
        [InlineData(42, "FizzWoof")]
        [InlineData(43, "Fizz")]
        [InlineData(44, "44")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(46, "46")]
        [InlineData(47, "Woof")]
        [InlineData(48, "Fizz")]
        [InlineData(49, "Woof")]
        [InlineData(50, "Buzz")]
        [InlineData(51, "FizzBuzz")]
        [InlineData(52, "Buzz")]
        [InlineData(53, "FizzBuzz")]
        [InlineData(54, "FizzBuzz")]
        [InlineData(55, "Buzz")]
        [InlineData(56, "BuzzWoof")]
        [InlineData(57, "FizzBuzzWoof")]
        [InlineData(58, "Buzz")]
        [InlineData(59, "Buzz")]
        [InlineData(60, "FizzBuzz")]
        [InlineData(61, "61")]
        [InlineData(62, "62")]
        [InlineData(63, "FizzWoof")]
        [InlineData(64, "64")]
        [InlineData(65, "Buzz")]
        [InlineData(66, "Fizz")]
        [InlineData(67, "Woof")]
        [InlineData(68, "68")]
        [InlineData(69, "Fizz")]
        [InlineData(70, "BuzzWoof")]
        [InlineData(71, "Woof")]
        [InlineData(72, "FizzWoof")]
        [InlineData(73, "FizzWoof")]
        [InlineData(74, "Woof")]
        [InlineData(75, "FizzBuzzWoof")]
        [InlineData(99, "Fizz")]
        [InlineData(375, "FizzBuzzWoof")]






































        public void FizzBuzzWoofTest(int number, string expected)
        {
            string result = FizzBuzzWoof(number);
            Assert.Equal(expected, result);
        }
    }
}
