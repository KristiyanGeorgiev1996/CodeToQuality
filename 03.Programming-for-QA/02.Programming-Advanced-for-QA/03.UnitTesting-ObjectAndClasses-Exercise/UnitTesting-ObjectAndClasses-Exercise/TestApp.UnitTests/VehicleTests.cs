using System;

using NUnit.Framework;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]
    public void Setup()
    {
        _vehicles = new Vehicles();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[]
        {
            "Car/Toyota/Camry/150",
            "Truck/Volvo/VNL/500",
            "Car/Ford/Focus/120",
        };
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string actual = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = $"Cars:{Environment.NewLine}Trucks:";

        // Act
        string actual = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}