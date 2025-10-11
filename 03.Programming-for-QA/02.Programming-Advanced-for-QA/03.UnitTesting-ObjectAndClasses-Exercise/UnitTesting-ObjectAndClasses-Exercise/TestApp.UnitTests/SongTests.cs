using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void Setup()
    {
        _song = new();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        string[] input = {
            "Pop_Song1_3:30",
            "Rock_Song2_4:15",
            "Pop_Song3_3:00"
        };
        string wantedList = "all";
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";

        // Act
        string actual = _song.AddAndListSongs(input, wantedList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] input = {
            "Pop_Song1_3:30",
            "Rock_Song2_4:15",
            "Pop_Song3_3:00",
            "Pop_Song1_3:40",
        };
        string wantedList = "Pop";
        string expected = $"Song1{Environment.NewLine}Song3{Environment.NewLine}Song1";

        // Act
        string actual = _song.AddAndListSongs(input, wantedList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        string[] input = {
            "Pop_Song1_3:30",
            "Rock_Song2_4:15",
            "Pop_Song3_3:00",
            "Pop_Song1_3:40",
        };
        string wantedList = "Metal";

        // Act
        string actual = _song.AddAndListSongs(input, wantedList);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}