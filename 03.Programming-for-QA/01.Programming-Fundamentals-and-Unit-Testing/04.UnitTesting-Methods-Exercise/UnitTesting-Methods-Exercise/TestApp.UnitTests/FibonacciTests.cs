using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    public void Test_CalculateFibonacci_ZeroInput(int number, int expected)
    {
        // Arrange
        //int number = 0;
        //int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(9, 34)]
    [TestCase(13, 233)]
    [TestCase(30, 832040)]
    public void Test_CalculateFibonacci_PositiveInput(int number, int expected)
    {
        // Arrange
        //int number = 9;
        //int expected = 34;

        // Act
        int result = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}