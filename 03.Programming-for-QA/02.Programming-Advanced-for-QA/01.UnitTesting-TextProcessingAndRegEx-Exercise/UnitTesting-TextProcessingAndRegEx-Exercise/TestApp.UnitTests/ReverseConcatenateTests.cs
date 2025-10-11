using System;
using System.Linq;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputData = Array.Empty<string>();
        string expected = string.Empty;

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] inputData = new string[] { "brown" };
        string expected = "brown";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] inputData = new string[] { "brown", "lazy", "dog" };
        string expected = "doglazybrown";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputData = null;
        string expected = string.Empty;

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] inputData = new string[] { "dog", " ", "lazy", " ", "brown" };
        string expected = "brown lazy dog";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        //string[] inputData = new string[] { "a", " ", "b", " ", "c", " ", "d" };
        //string expected = "d c b a";

        string[] inputData = new string[10000];
        for (int i = 0; i < inputData.Length; i++)
        {
            inputData[i] = i.ToString();
        }

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(inputData);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Join("", inputData.Reverse())));
    }
}