using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        //Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(emptyArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 5 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 2, 3, 4, 5 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 48, 108, -1, 5, -1, 5 };
        //repeating numbers: -1, 5
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        //Arrange
        int[] inputArray = new int[] { 12, 12, 12, 12, 12 };
        //repeating numbers: 12
        int expected = 12;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        //Arrange
        int[] inputArray = new int[] { 42, 108, 42, 5, 108, 5 };
        //repeating numbers: 42, 108, 5
        int expected = 42;

        //Act
        int result = RepeatingChecker.FindFirstRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}