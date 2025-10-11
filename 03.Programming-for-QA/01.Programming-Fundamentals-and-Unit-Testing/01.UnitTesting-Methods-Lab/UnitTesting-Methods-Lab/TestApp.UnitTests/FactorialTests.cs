using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int number = 0;
        int expected = 1;

        // Act
        int result = Factorial.CalculateFactorial(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int number = 7;
        int expected = 5040;

        // Act
        int result = Factorial.CalculateFactorial(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}