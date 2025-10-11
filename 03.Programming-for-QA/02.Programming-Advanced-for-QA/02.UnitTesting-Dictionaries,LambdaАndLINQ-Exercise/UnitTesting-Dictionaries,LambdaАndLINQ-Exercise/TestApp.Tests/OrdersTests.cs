using System;

using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 5.97 1",
            "banana 3.75 1",
            "orange 1.98 1",
        };

        string expected = $"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.25 3",
            "banana 1.50 4",
            "orange 2.00 1",
        };

        string expected = $"apple -> 3.75{Environment.NewLine}banana -> 6.00{Environment.NewLine}orange -> 2.00";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.25 4.38",
            "banana 1.50 8.73",
            "orange 2.19 1.25",
        };

        string expected = $"apple -> 5.48{Environment.NewLine}banana -> 13.10{Environment.NewLine}orange -> 2.74";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}