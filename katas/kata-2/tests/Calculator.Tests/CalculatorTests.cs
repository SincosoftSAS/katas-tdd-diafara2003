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
        public void Add_TwoPositiveNumbers_ReturnsSum(int numero1, int numero2, int esperado)
        {
            // Act
            var result = _calculator.Add(numero1, numero2);

            // Assert
            result.Should().Be(esperado);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(10, 0, 10)]
        [InlineData(0, 10, -10)]
        [InlineData(5, 5, 0)]
        public void Subtract_TwoNumbers_ReturnsDifference(int numero1, int numero2, int esperado)
        {
            // Act
            int result = _calculator.Subtract(numero1, numero2);

            // Assert
            result.Should().Be(esperado);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(10, 0, 0)]
        [InlineData(5, 5, 25)]
        public void Multiply_TwoNumbers_ReturnsDifference(int numero1, int numero2, int esperado)
        {
            // Act
            int result = _calculator.Multiply(numero1, numero2);

            // Assert
            result.Should().Be(esperado);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsDifference()
        {
            int a = 10, b = 5;

            int result = _calculator.Divide(a, b);

            result.Should().Be(2);
        }

        // TODO: Implementa más tests usando TDD
        // Suggestions:
        // - Test multiply with positive numbers
        // - Test divide with positive numbers  
        // - Test edge cases (division by zero, negative numbers, etc.)
    }
}