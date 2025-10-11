using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    PalindromeIntegers pi; // декларирам променлива pi

    [SetUp]
    public void SetUp()
    {
        pi = new PalindromeIntegers(); // инициализирам променливата
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        List<int> emptyList = new List<int>();

        // Act
        List<int> result = pi.FindPalindromes(emptyList);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 123, 423, 674, 534 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 3, 7, 5, 9 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 353, 7227, 151, 999 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(numbers, result);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        // Arrange
        List<int> numbers = new List<int>() { 353, 72, 158, 9991, 57575 };
        List<int> expected = new List<int>() { 353, 57575 };

        // Act
        List<int> result = pi.FindPalindromes(numbers);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}