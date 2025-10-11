using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class PlanetTests
{
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        Planet earth = new Planet("Earth", 12_742, 149_600_000, 1);
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

        // Act
        double actual = earth.CalculateGravity(mass);

        // Assert
        Assert.That(actual, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet earth = new Planet("Earth", 12_742, 149_600_000, 1);
        string expected =
        "Planet: Earth" + Environment.NewLine +
        "Diameter: 12742 km" + Environment.NewLine +
        "Distance from the Sun: 149600000 km" + Environment.NewLine +
        "Number of Moons: 1";

        // Act
        string actual = earth.GetPlanetInfo();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}