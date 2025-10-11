using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{

    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>(); //празен масив от цели числа

        // Act
        int[] result = Duplicates.RemoveDuplicates(emptyArray);

        // Assert
        Assert.That(result, Is.Empty);
    }


    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 2, 3 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 2, 3, 1, 5, 2, 2, 4, 3 };
        int[] expectedArray = new int[] { 1, 2, 3, 5, 4 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 1, 1, 1, 1 };
        int[] expectedArray = new int[] { 1 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }
}