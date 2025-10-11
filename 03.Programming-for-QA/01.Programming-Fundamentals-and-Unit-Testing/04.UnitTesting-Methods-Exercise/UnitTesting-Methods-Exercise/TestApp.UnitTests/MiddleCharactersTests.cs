using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyString = string.Empty;
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        // Arrange
        string emptyString = " ";
        string expected = "Empty string";

        // Act
        string result = MiddleCharacters.GetMiddleChars(emptyString);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        // Arrange
        string input = "A";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        // Arrange
        string input = "purple";
        string expected = "rp";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        // Arrange
        string input = "mouse";
        string expected = "u";

        // Act
        string result = MiddleCharacters.GetMiddleChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}