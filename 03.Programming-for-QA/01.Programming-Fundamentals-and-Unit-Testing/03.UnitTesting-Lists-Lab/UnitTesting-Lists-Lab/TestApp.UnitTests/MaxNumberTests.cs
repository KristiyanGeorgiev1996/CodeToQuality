using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> list = new List<int> { 4 };
        int expectedNumber = 4;

        //Act
        int actualNumber = MaxNumber.FindMax(list);

        //Assert
        Assert.That(expectedNumber, Is.EqualTo(actualNumber));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { 4, 3, 5, 9, 1 };
        int expectedMaxNumber = 9;

        //Act
        int actualMaxNumber = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { -4, -3, -5, -9, -1 };
        int expectedMaxNumber = -1;

        //Act
        int actualMaxNumber = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { -4, 3, -5, 9, -1 };
        int expectedMaxNumber = 9;

        //Act
        int actualMaxNumber = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> numbers = new List<int> { -4, 3, 9, -5, 9, -1 };
        int expectedMaxNumber = 9;

        //Act
        int actualMaxNumber = MaxNumber.FindMax(numbers);

        //Assert
        Assert.That(actualMaxNumber, Is.EqualTo(expectedMaxNumber));
    }
}