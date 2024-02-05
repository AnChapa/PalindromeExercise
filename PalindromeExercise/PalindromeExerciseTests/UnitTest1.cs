using PalindromeExercise;
using System;
using System.Diagnostics.SymbolStore;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("radar", true)]
        [InlineData("level", true)]
        [InlineData("hello", false)]
        [InlineData("madam", true)]
        [InlineData("racecars", false)]
        public void PalindromeTest(string input, bool expected)
        {
            WordSmith pal = new WordSmith();
            bool actual = pal.IsAPalindrome(input);
            Assert.Equal(expected, actual);
        }
    }
}
