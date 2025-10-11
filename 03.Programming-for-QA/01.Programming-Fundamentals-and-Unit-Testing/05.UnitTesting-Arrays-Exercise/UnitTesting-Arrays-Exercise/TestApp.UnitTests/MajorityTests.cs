using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        //Arrange
        int[] numbers = Array.Empty<int>();
        int expected = 0;

        //Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        //Arrange
        int[] numbers = new int[] { 0, 0, 0, 0 };
        int expected = 0;

        //Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        //Arrange
        int[] numbers = new int[] { 1, 2, 3, 4 };
        int expected = 0;

        //Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        //Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 6, 8 };
        int expected = 2; //бр. четни = 4 - бр. нечетни = 2

        //Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        //Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 7, 9 };
        int expected = -3; //бр. четни = 2 - бр. нечетни = 5

        //Act
        int result = Majority.IsEvenOrOddMajority(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}