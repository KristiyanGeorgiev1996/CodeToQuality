using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new Calculate();
        int expected = 7;

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new Calculate();
        int expected = 6;

        // Act
        int actual = calculator.Subtraction(10, 4);

        // Assert
        Assert.AreEqual(expected, actual, "Subtraction did not work properly.");
    }
}