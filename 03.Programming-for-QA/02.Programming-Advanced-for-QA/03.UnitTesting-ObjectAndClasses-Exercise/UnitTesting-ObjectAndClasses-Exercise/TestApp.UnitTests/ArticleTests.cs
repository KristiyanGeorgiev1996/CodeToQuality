using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void Setup()
    {
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = new string[]
        {
            "Article1 Content1 Author1",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3",
        };

        // Act
        Article actual = _article.AddArticles(input);

        // Assert
        Assert.That(actual.ArticleList, Has.Count.EqualTo(3));
        Assert.That(actual.ArticleList[0].Title, Is.EqualTo("Article1"));
        Assert.That(actual.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(actual.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        _article.ArticleList.Add(new Article
        {
            Author = "A1",
            Content = "C1",
            Title = "T2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A2",
            Content = "C2",
            Title = "T3"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A3",
            Content = "C3",
            Title = "T1"
        });
        string printCriteria = "title";
        string expected =
            "T1 - C3: A3"
            + Environment.NewLine +
             "T2 - C1: A1"
            + Environment.NewLine +
             "T3 - C2: A2";

        // Act
        string actual = _article.GetArticleList(_article, printCriteria);

        // Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        _article.ArticleList.Add(new Article
        {
            Author = "A1",
            Content = "C1",
            Title = "T2"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A2",
            Content = "C2",
            Title = "T3"
        });
        _article.ArticleList.Add(new Article
        {
            Author = "A3",
            Content = "C3",
            Title = "T1"
        });
        string printCriteria = "INVALID";

        // Act
        string actual = _article.GetArticleList(_article, printCriteria);

        // Assert 
        Assert.That(actual, Is.Empty);
    }
}