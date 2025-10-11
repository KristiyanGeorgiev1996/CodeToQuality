using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = @"http:/o.a?searchTerm=gotvarsk%20pechka&orderby=date
                        www.abc.bg
                        abc.bg";
        List<string> expected = new();

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = @"https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date";
        List<string> expected = new()
        {
            "https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date"
        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = @"https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date
                        https://wwww.onlineshop.a0?searchTerm=gotvarsk%20pechka&orderby=date
                        https://onlineshop.a0?searchTerm=gotvarsk%20pechka&orderby=date
                        https://o.a?searchTerm=gotvarsk%20pechka&orderby=date
                        https://www.wwww.wwww.wwwww.o.a?searchTerm=gotvarsk%20pechka&orderby=date";
        List<string> expected = new()
        {
            "https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date",
            "https://wwww.onlineshop.a0?searchTerm=gotvarsk%20pechka&orderby=date",
            "https://onlineshop.a0?searchTerm=gotvarsk%20pechka&orderby=date",
            "https://o.a?searchTerm=gotvarsk%20pechka&orderby=date",
            "https://www.wwww.wwww.wwwww.o.a?searchTerm=gotvarsk%20pechka&orderby=date"
        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Count, Is.EqualTo(expected.Count));
        Assert.That(actual, Is.Not.Empty);
        Assert.That(actual, Has.Exactly(5).Items);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "\"https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date\"";
        List<string> expected = new()
        {
            "https://wwww.onlineshop.commmm?searchTerm=gotvarsk%20pechka&orderby=date"
        };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}