using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [TestCase("5a")]
    [TestCase("3.5")]
    [TestCase("five")]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage(string input)
    {
        // Arrange
        string expected = "The input is not an integer!";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        // Arrange
        string input = "0";
        string expected = $"The number {input} is zero.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        // Arrange
        string input = "-3";
        string expected = $"The number {input} is negative.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        // Arrange
        string input = "42";
        string expected = $"The number {input} is positive.";

        // Act
        string result = SignOfIntegerNumbers.CheckSign(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}