using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act
        double[] result = Sorting.ShallowAscendingSort(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        // Arrange
        double[] emptyArray = Array.Empty<double>();

        // Act
        double[] result = Sorting.DeepAscendingSort(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        // Arrange
        double[] originalArray = { 4.2, 1.8, 2.8, 2.3 };

        double[] originalExpected = { 4.2, 1.8, 2.8, 2.3 };
        double[] expected = { 1.8, 2.3, 2.8, 4.2 };

        // Act 
        double[] result = Sorting.ShallowAscendingSort(originalArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
        CollectionAssert.AreEqual(originalExpected, originalArray);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        // Arrange
        double[] originalArray = { 4.2, 1.8, 2.8, 2.3 };

        double[] expected = { 1.8, 2.3, 2.8, 4.2 };

        // Act
        double[] result = Sorting.DeepAscendingSort(originalArray);

        // Assert
        CollectionAssert.AreEqual(expected, result);
        CollectionAssert.AreEqual(expected, originalArray);
    }
}