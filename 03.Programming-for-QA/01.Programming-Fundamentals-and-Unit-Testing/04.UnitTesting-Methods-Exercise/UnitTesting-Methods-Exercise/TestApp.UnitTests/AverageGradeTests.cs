using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [TestCase(new double[] { 1, 2, 1.5 })]
    [TestCase(new double[] { 1.99, 1.99, 1.99 })]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage(double[] array)
    {
        // Arrange
        List<double> grades = new List<double>(array);
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 5, 6, 6.5, 7 })]
    [TestCase(new double[] { 6.01, 6.01, 6.01 })]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage(double[] array)
    {
        // Arrange
        List<double> grades = new List<double>(array);
        string expected = "Incorrect grades";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 2, 3, 3.5, 2, 2 })]
    [TestCase(new double[] { 2, 2, 2, 2, 2 })]
    [TestCase(new double[] { 2.99, 2.99, 2.99 })]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage(double[] array)
    {
        // Arrange
        List<double> grades = new List<double>(array);
        string expected = "Fail";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new double[] { 3, 4, 3, 3.5 })]
    [TestCase(new double[] { 3, 3, 3 })]
    [TestCase(new double[] { 3.49, 3.49, 3.49 })]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage(double[] array)
    {
        // Arrange
        List<double> grades = new List<double>(array);
        string expected = "Poor";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 4, 3, 5, 4.5 };
        string expected = "Good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 5, 4, 4.80, 5.20, 5.30 };
        string expected = "Very good";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        // Arrange
        List<double> grades = new List<double>() { 5.30, 6, 5.50, 6, 5.80 };
        string expected = "Excellent";

        // Act
        string result = AverageGrade.GetGradeDefinition(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}