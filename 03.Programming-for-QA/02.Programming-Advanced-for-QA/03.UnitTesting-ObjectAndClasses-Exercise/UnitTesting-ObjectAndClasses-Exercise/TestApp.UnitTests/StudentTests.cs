using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class StudentTests
{
    // Good to know 
    // Filed
    // 4 principles of OOP 
    // Interfaces
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new();
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] input = {
            "John Doe 25 Sofia", // Sofia
            "Jane Smith 22 Varna",
            "Alice Johnson 20 Sofia" // Sofia
        };
        string filterTown = "Sofia";
        string expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";

        // Act
        string actual = this._student.AddAndGetByCity(input, filterTown);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] input = {
            "John Doe 25 Sofia", // Sofia
            "Jane Smith 22 Varna",
            "Alice Johnson 20 Sofia" // Sofia
        };
        string filterTown = "Shumen";
        string expected = string.Empty;

        // Act
        string actual = this._student.AddAndGetByCity(input, filterTown);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        // Arrange
        string filterTown = "Shumen";
        string expected = string.Empty;

        // Act
        string actual = this._student.AddAndGetByCity(Array.Empty<string>(), filterTown);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}