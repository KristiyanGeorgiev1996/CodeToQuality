using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("@example.com")] // missing username
    [TestCase("test@")]        // missing host
    [TestCase("testexample")] // missing @
    public void Test_IsValidEmail_InvalidEmail(string email)
    {
        // Arrange

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }

    [TestCase(null)]
    [TestCase(" ")]
    public void Test_IsValidEmail_NullInput(string email)
    {
        // Arrange
        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}