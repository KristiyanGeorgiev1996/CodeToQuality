using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "level", "omo", "radar", "refer", "racecar" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new();

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "racecar" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new List<string>() { "Hello", "angel", "test" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_PalindromeAndNonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new List<string>() { "radar", "omo", "test", "civic" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "Level", "omO", "rAdar", "rEFer", "RAceCar" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.That(result, Is.True);
    }
}