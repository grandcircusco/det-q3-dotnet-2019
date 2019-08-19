using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static PasswordVerifierTDD.PasswordVerifier;

namespace PasswordVerifierTDD
{
    public class PasswordVerifierTest
    {
        [Fact]
        public void LengthChecker1()
        {
            bool result = Verify("abcdefg");
            Assert.False(result);
        }

        [Fact]
        public void LengthChecker2()
        {
            bool result = Verify("Abcdefgh1");
            Assert.True(result);
        }

        [Theory]
        [InlineData("helloworld", false)]
        [InlineData("helloWorld2", true)]
        public void CheckForCapitalLetter(string password, bool expected)
        {
            bool result = Verify(password);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("helloWorld", false)]
        [InlineData("helloWorld2", true)]
        public void CheckForNumber(string password, bool expected)
        {
            bool result = Verify(password);
            Assert.Equal(expected, result);
        }
    }
}
