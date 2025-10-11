using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int num = 0;
        string expected = "";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int num = 3;
        string expected = $"1{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1 2 3{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int num = 5;
        string expected = $"1{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1 2 3{Environment.NewLine}" +
                          $"1 2 3 4{Environment.NewLine}" +
                          $"1 2 3 4 5{Environment.NewLine}" +
                          $"1 2 3 4{Environment.NewLine}" +
                          $"1 2 3{Environment.NewLine}" +
                          $"1 2{Environment.NewLine}" +
                          $"1";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    // допълнителни тестове - не са за Judge
    [Test]
    public void Test_Triangle_OutputMatchesExpected_NegativeSize()
    {
        // Arrange
        int num = -5;
        string expected = "";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_SizeOne()
    {
        // Arrange
        int num = 1;
        string expected = "1";

        // Act
        string result = Triangle.PrintTriangle(num);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}