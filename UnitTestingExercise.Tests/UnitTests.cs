using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(-5, 6, 29, 30)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 5, 0)]
        [InlineData(29, 9, 20)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(5, 5, 25)]
        [InlineData(-2, 9, -18)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(15, 5, 3)]
        [InlineData(27, 9, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
                var test = new UnitTestMethods();
            //Act
                var actual = test.YourMethodName();
            //Assert
                Assert.Equal("joe biden", actual);

        }

       [Fact]
        public void ReturnZero()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.ReturnZero();
            //Assert
            Assert.Equal(0, actual);
        }
    }
}
