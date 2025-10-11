using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        // Arange
        string[] array = { "", "", "" };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        // Arange
        string[] array = { "abc" };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        // Arange
        string[] array = { "abc", "abcdf", "x" };

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        // Arange
        string[] array = { "abcd" };
        string expected = "abcd";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        // Arange
        string[] array = { "abc", "abcd", "x", "go", "Hello", "Hi" };
        string expected = "abcd go Hi";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // Additional tests - > several even strings & EmptyArray - (Not for Judge)

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenLengthWords_ShouldReturnSameWord()
    {
        // Arange
        string[] array = { "abcd", "Go", "Hi" };
        string expected = "abcd Go Hi";

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_EmptyInputArray_ShoudReturnEmptyString()
    {
        // Arrange
        string[] emptyArray = Array.Empty<string>();

        // Act
        string result = EvenLengthWordsFilter.GetEvenWords(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }
}