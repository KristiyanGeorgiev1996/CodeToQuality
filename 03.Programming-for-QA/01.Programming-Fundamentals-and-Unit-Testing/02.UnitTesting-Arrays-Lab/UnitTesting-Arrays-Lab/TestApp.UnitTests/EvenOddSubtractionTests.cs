using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = 0;

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [TestCase(new int[] { 2, 6, 8, 4 }, 20)]
    [TestCase(new int[] { -2, -6, -8, -4 }, -20)]
    [TestCase(new int[] { -2, 6, -8, 14 }, 10)]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum(int[] numbers, int expected)
    {
        // Arrange
        //int[] numbers = new int[] { 2, 6, 8, 4 };
        //int expected = 20;

        // Act
        int result = EvenOddSubtraction.FindDifference(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] numbers = new int[] { 3, 11, 7 };
        int expected = -21;

        // Act
        int result = EvenOddSubtraction.FindDifference(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] numbers = new int[] { 3, 54, 4, 7, 13, 5 };
        int expected = 30;

        // Act
        int result = EvenOddSubtraction.FindDifference(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}