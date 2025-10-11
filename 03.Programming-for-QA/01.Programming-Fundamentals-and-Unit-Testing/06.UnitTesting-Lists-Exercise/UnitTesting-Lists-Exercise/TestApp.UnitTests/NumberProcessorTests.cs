using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 49, 81 };
        List<double> expected = new() { 3, 7, 9 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<double> expected = new() { 0 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // Tests not for Judge
    [Test]
    public void Test_ProcessNumbers_WithOddAndEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 9, 6, 81 };
        List<double> expected = new() { 4, 3, 36, 9 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_OddNumbersSquareRootWithDecimalSymbols()
    {
        // Arrange
        List<int> input = new() { 21, 39 };
        List<double> expected = new() { 4.58, 6.24 };

        // Act
        List<double> result = NumberProcessor.ProcessNumbers(input);

        // Assert
        //CollectionAssert.AreEqual(expected, result);
        Assert.That(result[0], Is.EqualTo(expected[0]).Within(0.01));
        Assert.That(result[1], Is.EqualTo(expected[1]).Within(0.01));
    }
}