using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] oneElementArray = new int[1] { 42 };
        string expected = "42";

        // Act
        string result = Reverse.ReverseArray(oneElementArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] numbers = new int[] { 5, 42, -8, 0, 7 };
        string expected = "7 0 -8 42 5";

        // Act
        string result = Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}