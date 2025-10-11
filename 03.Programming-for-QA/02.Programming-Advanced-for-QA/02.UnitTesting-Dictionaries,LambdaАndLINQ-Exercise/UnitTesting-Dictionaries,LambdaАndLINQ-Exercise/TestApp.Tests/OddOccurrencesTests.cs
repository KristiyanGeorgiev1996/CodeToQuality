using System;

using NUnit.Framework;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "hello", "hello", "softuni", "softuni" };

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "hello", "hello", "hello" };
        string expected = "hello";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "hello", "softuni", "hello", "softuni", "hello", "softuni", "QA's" };

        string expected = "hello softuni qa's";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "Hello", "SoftUni", "heLLo", "Softuni", "hELlo", "SOFTUNI", "QA's" };

        string expected = "hello softuni qa's";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}