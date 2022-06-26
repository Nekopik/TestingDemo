using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(43, 35.2, 78.2)]
        [InlineData(21.25, 11.75, 33)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 6, 14)]
        [InlineData(132, 32.4, 99.6)]
        [InlineData(double.MaxValue, double.MaxValue, 0)]
        [InlineData(52.3, 14.8, 37.5)]
        public void Subtract_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(163, 99, 16137)]
        [InlineData(22.3, 12, 267.6)]
        [InlineData(42.8, 21.3, 911.64)]
        [InlineData(double.MaxValue, 3, double.MaxValue)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]
        [InlineData(222, 5, 44.4)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
