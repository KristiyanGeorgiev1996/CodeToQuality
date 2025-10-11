using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        //Arrange
        List<int> emptyList = new List<int>();
        string expectedText = "No elements!";

        //Act
        string resultText = ListAnalyzer.Analyze(emptyList);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> listWithOneElement = new List<int> { 6 };
        string expectedText = "Element count: 1, Min value: 6, Max value: 6, Avg: 6.00.";

        //Act
        string resultText = ListAnalyzer.Analyze(listWithOneElement);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        //Arrange
        List<int> listWithSameElements = new List<int> { 6, 6, 6 };
        string expectedText = "Element count: 3, Min value: 6, Max value: 6, Avg: 6.00.";

        //Act
        string resultText = ListAnalyzer.Analyze(listWithSameElements);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));

    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        //Arrange
        List<int> numbers = new List<int> { 3, 4, 5, 7 };
        string expectedText = "Element count: 4, Min value: 3, Max value: 7, Avg: 4.75.";

        //Act
        string resultText = ListAnalyzer.Analyze(numbers);

        //Assert
        Assert.That(resultText, Is.EqualTo(expectedText));

    }
}