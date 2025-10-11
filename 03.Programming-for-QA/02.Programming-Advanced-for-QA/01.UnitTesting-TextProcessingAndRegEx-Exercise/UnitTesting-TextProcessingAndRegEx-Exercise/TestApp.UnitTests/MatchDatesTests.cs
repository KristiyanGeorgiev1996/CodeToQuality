using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "26-August-1994";
        string expected = "Day: 26, Month: August, Year: 1994";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = @"26-august-1994
                         26.august.1994
                         26/august/1994
                         26-august.1994
                         26/august.1994
                         26-august/1994
                         26-August.1994
                         26/August.1994
                         26-August/1994
                         26-AugusT-1994";
        string expected = string.Empty;

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "26-August-1994 27.August.1994 28/August/1994";
        string expected = "Day: 26, Month: August, Year: 1994";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;

        // Act + Assert
        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);
    }
}