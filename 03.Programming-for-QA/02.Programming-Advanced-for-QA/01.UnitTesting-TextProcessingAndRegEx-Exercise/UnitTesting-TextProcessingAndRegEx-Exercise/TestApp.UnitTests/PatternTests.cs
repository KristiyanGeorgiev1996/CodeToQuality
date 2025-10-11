using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("asd", 2, "aSdaSd")]
    [TestCase("ASD", 2, "aSdaSd")]
    [TestCase("aSd", 2, "aSdaSd")]
    [TestCase("AsD", 2, "aSdaSd")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
        int repetitionFactor, string expected)
    {
        // Act
        string actual = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int ignoreRepetitionFactor = 999;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, ignoreRepetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "ignoreInputString";
        int ignoreRepetitionFactor = -1;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, ignoreRepetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "ignoreInputString";
        int ignoreRepetitionFactor = 0;

        // Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, ignoreRepetitionFactor), Throws.ArgumentException);
    }
}