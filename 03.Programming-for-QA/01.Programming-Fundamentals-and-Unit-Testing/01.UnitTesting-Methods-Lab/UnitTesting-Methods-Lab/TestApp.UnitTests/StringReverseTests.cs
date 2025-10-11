using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hello!";
        string expected = "!olleH";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}