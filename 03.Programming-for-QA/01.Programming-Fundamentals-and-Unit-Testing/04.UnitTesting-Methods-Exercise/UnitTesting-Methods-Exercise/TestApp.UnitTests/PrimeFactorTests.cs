using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [TestCase(2)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(389)]
    public void Test_FindLargestPrimeFactor_PrimeNumber(int primeNumber)
    {
        // Arrange
        //long primeNumber = 11;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        // Assert
        Assert.That(result, Is.EqualTo(primeNumber));
    }

    [TestCase(48625, 389)]
    [TestCase(4566053543345, 71562629)] // not for Judge!!!
    public void Test_FindLargestPrimeFactor_LargeNumber(long number, long expected)
    {
        // Arrange
        //long number = 48625;
        //long expected = 389;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // Test - not for Judge
    [TestCase(0)]
    [TestCase(1)]
    public void Test_FindLargestPrimeFactor_TestWithZeroAndOne(int number)
    {
        // Arrange
        long expected = 1;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}