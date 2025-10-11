using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>() { 1, 2, 3 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>();

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        // Arrange
        List<int> firstList = new List<int>() { 1, 2, 3 };
        List<int> secondList = new List<int>() { 4, 5, 6, 7 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new() { 3, 42, 8, 101, 75 };
        List<int> secondList = new() { 2, 42, 7, 101, 42, 5, 13 };
        List<int> expected = new() { 42, 101 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert - legacy
        CollectionAssert.AreEqual(expected, result);

        // Assert - modern
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]  // not for Judge
    public void Test_FindSameValues_AllWithSameValues_ReturnsListWithSameValues()
    {
        // Arrange
        List<int> firstList = new() { 3, 42, 8, 101 };
        List<int> secondList = new() { 3, 42, 8, 101 };

        // Act
        List<int> result = SameValues.FindSameValues(firstList, secondList);

        // Assert - legacy approach
        CollectionAssert.AreEqual(firstList, result);

        // Assert - modern approach
        Assert.That(result, Is.EquivalentTo(firstList));
    }
}