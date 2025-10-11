using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        // Arrange
        List<int> input = new();

        // Act
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.Empty);
        Assert.That(result.odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        // Arrange
        List<int> input = new() { 2, 6, 16, 10 };

        // Act
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.EquivalentTo(input));
        Assert.That(result.odd, Is.Empty);

    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        // Arrange
        List<int> input = new() { 3, 17, 7, 39, 53 };

        // Act
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.Empty);
        Assert.That(result.odd, Is.EquivalentTo(input));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        // Arrange
        List<int> input = new() { 3, 17, 42, 39, 8, 53, 2, 253 };
        List<int> expectedOdds = new() { 3, 17, 39, 53, 253 };
        List<int> expectedEvens = new() { 42, 8, 2 };

        // Act
        (List<int> even, List<int> odd) result = ListSplitter.SplitEvenAndOdd(input);

        // Assert
        Assert.That(result.even, Is.EquivalentTo(expectedEvens));
        Assert.That(result.odd, Is.EquivalentTo(expectedOdds));
    }
}