using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        //Arrange
        char[] inputArray = new char[] { 'A', 'z', '3', '9', '#', '*' };
        char[] expectedArray = new char[] { 'A', 'z', '#', '*' };

        //Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(expectedArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        //Arrange
        char[] inputArray = new char[] { 'A', 'b', '&', '#' };

        //Act
        char[] result = Fake.RemoveStringNumbers(inputArray);

        //Assert
        Assert.That(result, Is.EqualTo(inputArray));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        char[] emptyArray = Array.Empty<char>(); //празен масив от символи

        //Act
        char[] result = Fake.RemoveStringNumbers(emptyArray);

        //Assert
        Assert.That(result, Is.Empty);
    }
}