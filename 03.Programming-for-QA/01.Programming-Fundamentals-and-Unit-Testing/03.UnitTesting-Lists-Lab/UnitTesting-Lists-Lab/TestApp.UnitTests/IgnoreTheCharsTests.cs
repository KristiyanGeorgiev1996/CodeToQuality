using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "";
        List<char> forbiddenChars = new List<char> { 'a', 'e' };

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(sentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        //Arrange
        string sentence = "I am Desi. I am 27 years old.";
        List<char> forbiddenChars = new List<char>();

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(sentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        //Arrange
        string sentence = "d";
        List<char> forbiddenChars = new List<char> { 'd' };
        string expectedSentence = "";

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(expectedSentence, Is.EqualTo(resultSentence));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        //Arrange
        string sentence = "Desi is 27 years old.";
        List<char> forbiddenChars = new List<char> { 'a', 'e', '.' };
        string expectedSentence = "Dsi is 27 yrs old";

        //Act
        string resultSentence = IgnoreTheChars.IgnoreChars(sentence, forbiddenChars);

        //Assert
        Assert.That(expectedSentence, Is.EqualTo(resultSentence));
    }
}