using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new();
        int treshold = 3;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        // Arrange
        List<int> input = new() { 6, 42, 13, 8 };
        int treshold = 5;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshold);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        // Arrange
        List<int> input = new() { 6, 42, 13, 8, 50 };
        int treshold = 50;

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshold);

        // Assert
        Assert.That(result, Is.EquivalentTo(input));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        // Arrange
        List<int> input = new() { 6, 42, 13, 20, 8, 50 };
        int treshold = 20;
        List<int> expected = new() { 6, 13, 20, 8 };

        // Act
        List<int> result = ListRemover.RemoveElementsGreaterThan(input, treshold);

        // Assert
        Assert.That(result, Is.EquivalentTo(expected));
    }
}