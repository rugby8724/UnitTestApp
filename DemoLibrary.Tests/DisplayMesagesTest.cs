using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;

// Arrange, Act, Assert
// expected and the actual

namespace DemoLibrary.Tests
{
    public class DisplayMesagesTest
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Tim";

            //Act
            string actual = messages.Greeting("Tim", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Tim";

            //Act
            string actual = messages.Greeting("Tim", 14);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", 0, "Good morning Tim")]
        [InlineData("Tim", 13, "Good afternoon Tim")]
        [InlineData("Tim", 22, "Good evening Tim")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();

            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
