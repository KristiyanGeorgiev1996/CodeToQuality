using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string> { "", "", "" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "aa", "Aa", "Bb", "bb", "c" };
        string expected =
            $"a -> 3"
            + Environment.NewLine
            + "A -> 1"
            + Environment.NewLine
            + "B -> 1"
            + Environment.NewLine
            + "b -> 3"
            + Environment.NewLine
            + "c -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "aa", "Aa", "@#" };
        string expected =
            $"a -> 3"
            + Environment.NewLine
            + "A -> 1"
            + Environment.NewLine
            + "@ -> 1"
            + Environment.NewLine
            + "# -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}