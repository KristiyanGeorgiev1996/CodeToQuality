using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.50, "Fail")]
    [TestCase(3.20, "Average")]
    [TestCase(3.80, "Good")]
    [TestCase(4.30, "Good")]
    [TestCase(5.20, "Very Good")]
    [TestCase(5.80, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
        //double grade = 2.50;
        //string expected = "Fail";

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(1.50, "Invalid!")]
    [TestCase(6.50, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}