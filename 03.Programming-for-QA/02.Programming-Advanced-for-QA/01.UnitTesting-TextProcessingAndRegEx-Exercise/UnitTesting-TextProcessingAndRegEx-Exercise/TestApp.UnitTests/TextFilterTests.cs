using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string text = "Brown lazy dog.";
        string expected = "Brown lazy dog.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "dog" };
        string text = "Brown lazy dog dog Dog.";
        string expected = "Brown lazy *** *** Dog.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Brown lazy dog dog Dog.";
        string expected = "Brown lazy dog dog Dog.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { " " };
        string text = "Brown lazy dog dog Dog.";
        string expected = "Brown*lazy*dog*dog*Dog.";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}