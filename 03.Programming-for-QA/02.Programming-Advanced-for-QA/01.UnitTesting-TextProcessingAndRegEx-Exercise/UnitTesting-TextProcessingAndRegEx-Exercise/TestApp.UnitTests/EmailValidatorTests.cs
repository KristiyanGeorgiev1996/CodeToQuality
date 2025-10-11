using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("a.a@a.aa")]
    [TestCase("111111@abc.test.test")]
    [TestCase("_f.j%o+r-d9anov@aBc9.-4.bb")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("_f.j%o+r-d9anov@aBc9.-4.b")]
    [TestCase("_f.j%o+r-d9anovaBc9.-4.bg")]
    [TestCase("_f.j%o+r-d9anovaBc9.-4bg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}