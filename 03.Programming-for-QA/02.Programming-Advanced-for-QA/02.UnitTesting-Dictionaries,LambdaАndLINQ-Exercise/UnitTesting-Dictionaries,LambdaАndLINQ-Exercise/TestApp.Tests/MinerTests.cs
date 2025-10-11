using System;

using NUnit.Framework;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "GoLd 1", "GOLD 2", "SilVer 18", "SILver 12", "gold 5" };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "GoLd 1", "GOLD 2", "SilVer 18", "SILver 12", "gold 5", "copper 100" };

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30{Environment.NewLine}copper -> 100"));
    }
}