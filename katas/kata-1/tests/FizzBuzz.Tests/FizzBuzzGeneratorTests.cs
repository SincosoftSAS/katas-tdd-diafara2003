using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    //jau
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void Generate_WithOne_ReturnsListWithOne()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(1);

            // Assert
            result.Should().HaveCount(1);
            result[0].Should().Be("1");
        }

        [Fact]
        public void Generate_WithTwo_ReturnsListWithOneYTwo()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(2);

            // Assert
            result.Should().HaveCount(2);
            result[0].Should().Be("1", "2");
        }

        [Fact]
        public void GenerateFizz_WithThree_ReturnsListWithOneTwoFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(3);

            // Assert
            result.Should().HaveCount(3);
            result.Should().BeEquivalentTo(["1", "2", "Fizz"]);
        }

        [Fact]
        public void GenerateBuzz_WithFive_ReturnsListWithOneTwoFizzFourBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(5);

            // Assert
            result.Should().HaveCount(5);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz"]);
        }

        [Fact]
        public void GenerateBuzz_WithSix_ReturnsListWithOneTwoFizzFourBuzzFizz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(6);

            // Assert
            result.Should().HaveCount(6);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz", "Fizz"]);
        }

        [Fact]
        public void GenerateBuzz_WithTen_ReturnsList()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(10);

            // Assert
            result.Should().HaveCount(10);
            result.Should().BeEquivalentTo(["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]);
        }

        [Fact]
        public void Generate_WithFifteen_ReturnsListWithFizzBuzz()
        {
            // Arrange & Act
            var result = FizzBuzzGenerator.Generate(15);
            
            // Assert
            result.Should().HaveCount(15);
            result[14].Should().Be("FizzBuzz");
        }
    }
}