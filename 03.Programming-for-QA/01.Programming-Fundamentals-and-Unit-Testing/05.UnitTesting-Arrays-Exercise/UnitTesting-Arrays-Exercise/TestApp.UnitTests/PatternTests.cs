using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] expectedArray = new int[] { 1, 15, 2, 12, 3, 10, 4 };

        //Act
        int[] result = Pattern.SortInPattern(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        int[] emptyArray = Array.Empty<int>(); //празен целочислен масив

        //Act
        int[] result = Pattern.SortInPattern(emptyArray);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        //Arrange
        int[] inputArray = new int[] { 5 };

        //Act
        int[] result = Pattern.SortInPattern(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }
}