using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        //Arrange
        int[] emptyArray = Array.Empty<int>();
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(emptyArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 5 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 1, 2, 3, 4, 5 };
        int expected = -1;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        //Arrange
        int[] inputArray = new int[] { 48, 108, -1, 5, -1, 5 };
        //repeating numbers: -1, 5
        int expected = 5;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        //Arrange
        int[] inputArray = new int[] { 12, 12, 12, 12, 12 };
        //repeating numbers: 12
        int expected = 12;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        //Arrange
        int[] inputArray = new int[] { 42, 108, 42, 51, 108, 51 };
        //repeating numbers: 42, 108, 51
        int expected = 51;

        //Act
        int result = RepeatingChecker.FindLastRepeatingElement(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}