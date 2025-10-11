using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };
        double expected = 42;

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { 1, 3, 4 };
        double expected = 8.0 / 3;

        // Act 
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { -1, -13, -4 };
        double expected = -18.0 / 3;

        // Act 
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = new int[] { 10, -13, -4, 18 };
        double expected = 11.0 / 4;

        // Act 
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // Demo test - All upper tests in one
    [TestCase(new int[] { 42 }, 42)]
    [TestCase(new int[] { 1, 3, 4 }, 8.0 / 3)]
    [TestCase(new int[] { -1, -13, -4 }, -18 / 3)]
    [TestCase(new int[] { 10, -13, -4, 18 }, 11.0 / 4)]
    public void Test_CalculateAverage_MixedTestCases(int[] array, double expected)
    {
        // Arrange

        // Act 
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}