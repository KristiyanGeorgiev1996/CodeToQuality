using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arange
        int[] array = new int[] { 0, -5, 1, -1, 1 };

        // Act 
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arange
        int[] array = new int[] { 6 };

        // Act 
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arange
        int[] array = new int[] { 6, 4, 8, 16 };

        // Act 
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arange
        int[] array = new int[] { 6, 8, 7, 10 }; // масив само с едно просто число
        int[] expected = new int[] { 7 };

        // Act 
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arange
        int[] array = new int[] { 6, 7, 3, 16, 11 };
        int[] expected = new int[] { 7, 3, 11 };

        // Act 
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(array);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}