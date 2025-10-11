using System;

using NUnit.Framework;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };
        string expected = "1 -> 1";

        // Act
        var actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 3, 2, 1, 1, 2, 3 };
        string expected =
            "1 -> 2"
            + Environment.NewLine
            + "2 -> 2"
            + Environment.NewLine
            + "3 -> 2";

        // Act
        var actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -4, -4, -10, -2 };
        string expected =
            $"-10 -> 1"
            + Environment.NewLine
            + "-4 -> 2"
            + Environment.NewLine
            + "-2 -> 1";

        // Act
        var actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0, 0 };
        string expected =
            $"0 -> 4";

        // Act
        var actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}