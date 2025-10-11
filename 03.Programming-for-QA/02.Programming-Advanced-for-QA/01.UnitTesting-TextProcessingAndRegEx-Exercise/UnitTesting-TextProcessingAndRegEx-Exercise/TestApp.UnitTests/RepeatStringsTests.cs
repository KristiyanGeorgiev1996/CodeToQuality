using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = new string[] { "AsD" };
        string expected = "AsDAsDAsD";

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = new string[] { "as", "df " };
        string expected = "asasdf df df";

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}