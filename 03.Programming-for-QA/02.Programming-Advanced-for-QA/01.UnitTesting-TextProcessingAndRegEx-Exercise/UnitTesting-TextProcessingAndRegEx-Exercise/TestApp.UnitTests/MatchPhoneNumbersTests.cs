using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string input = @"+359-2-124-5678, 
                         +359 2 986 5432,
                         +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string input = @"+35-2-123-1234 
                        +358-2-123-1234 
                        +359-2-1223-1234 
                        +359-2-12-1234 
                        +359-3-123-1234 
                        +359-2-123-12345 
                        359-2-123-1234 
                        +359 2-123 1234
                        +359 2-123 1234 
                        +359-2 123-1234";
        string expected = string.Empty;

        // Act
        string actual = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string expected = string.Empty;

        // Act
        string actual = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string input = @"+359-2-124-5678,
                        +359 2 986 5432,
                        +35-2-123-1234
                        +358-2-123-1234 
                        +359-2-1223-1234 
                        +359-2-12-1234 
                        +359-3-123-1234 
                        +359-2-123-12345 
                        359-2-123-1234 
                        +359 2-123 1234
                        +359 2-123 1234 
                        +359-2 123-1234
                        +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}