using AlphabetCheckWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace AlphabetCheckApi.Tests
{
    public class AlphabetCheckControllerTests
    {
        private readonly AlphabetCheckController _controller;
        public AlphabetCheckControllerTests()
        {
            _controller = new AlphabetCheckController();
        }

        [Theory]
        [InlineData("The quick brown fox jumps over the lazy dog", true)]  // Contains all letters
        [InlineData("Hello World", false)]  // Missing letters
        [InlineData("abcdefghijklmnopqrstuvwxyz", true)]  // Exactly all letters
        [InlineData("1234567890!@#$%^", false)]  // No letters at all
        public void CheckAlphabet_ShouldReturnCorrectResult(string input, bool expected)
        {
            // Act
            var result = _controller.CheckAllAlphabets(input);

            // Assert
            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actual = (bool)actionResult.Value;
            Assert.Equal(expected, actual);
        }
    }
}
