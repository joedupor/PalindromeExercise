using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("madam", true)]
        [InlineData("deified", true)]
        [InlineData("levels", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();

            //Act - this is just a method that calls another method
            bool actual = instance.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }

       
    }
}
