using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        var input = new List<int>();

        // Act
        var actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        string expected =
            $"Odd numbers: 9, 7, 5, 3, 1"
            + Environment.NewLine +
            $"Even numbers: 8, 6, 4, 2";

        // Act
        var actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 8, 6, 4, 2 };
        string expected =
            $"Even numbers: 8, 6, 4, 2";

        // Act
        var actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { 9, 7, 5, 3, 1 };
        string expected =
            $"Odd numbers: 9, 7, 5, 3, 1";

        // Act
        var actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        var input = new List<int>() { -9, -8, -7, -6, -5, -4, -3, -2, -1 };
        string expected =
            $"Odd numbers: -9, -7, -5, -3, -1"
            + Environment.NewLine +
            $"Even numbers: -8, -6, -4, -2";

        // Act
        var actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}