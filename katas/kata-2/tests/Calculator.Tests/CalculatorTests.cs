using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(10, 4, 14)]
        [InlineData(0, 10, 10)]
        public void Add_TwoPositiveNumbers_ReturnsSum(int numero1, int numero2, int experado)
        {
            // Act
            var result = _calculator.Add(numero1, numero2);

            // Assert
            result.Should().Be(experado);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 4;
        
            // Act
            int result = _calculator.Subtract(a, b);
        
            // Assert
            result.Should().Be(6);
        }

        // TODO: Implementa más tests usando TDD
        // Suggestions:
        // - Test multiply with positive numbers
        // - Test divide with positive numbers  
        // - Test edge cases (division by zero, negative numbers, etc.)
    }
}