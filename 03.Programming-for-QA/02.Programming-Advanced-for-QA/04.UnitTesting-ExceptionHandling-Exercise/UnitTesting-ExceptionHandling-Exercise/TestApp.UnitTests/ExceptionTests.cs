using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new(); //_exceptions -> обект от класа Exceptions, чрез който можем да викаме методите
    }


    //Task 1
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string text = "Hello";
        string expected = "olleH";

        // Act
        string result = _exceptions.ArgumentNullReverse(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    //Task 1
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string text = null;
        string expectedMessage = "String cannot be null. (Parameter 's')";

        // Act & Assert
        //тестваме дали ще получим exception
        Assert.That(() => _exceptions.ArgumentNullReverse(text), Throws.ArgumentNullException);

        //EXTRA: тестваме дали ще получим определен exception със съобщение
        try
        {
            _exceptions.ArgumentNullReverse(text);
        }
        catch (ArgumentNullException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedMessage));
        }

    }

    //Task 2
    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        decimal totalPrice = 20;
        decimal discount = 5;
        decimal expected = 19;

        //Act
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 2
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 20;
        decimal discount = -5;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);

    }

    //Task 2
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 20;
        decimal discount = 105;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    //Task 3
    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        int[] numbers = { 10, 20, 30, 40, 50 };
        //валидни позиции: [0; 4]
        int index = 2;
        int expected = 30;

        //Act
        int result = _exceptions.IndexOutOfRangeGetElement(numbers, index);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 3
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] numbers = { 10, 20, 30, 40, 50 };
        //валидни позиции: [0; 4]
        int index = -2;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(numbers, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    //Task 3
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] numbers = { 10, 20, 30, 40, 50 };
        int index = numbers.Length; // 5

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(numbers, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    //Task 3
    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] numbers = { 10, 20, 30, 40, 50 };
        int index = 10;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(numbers, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    //Task 4
    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";

        //Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 4
    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        //Arrange
        bool isLoggedIn = false;

        //Act & Assert
        //провер€ваме дали получаваме дадени€ exception
        Assert.That(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InvalidOperationException);

        //провер€ваме дали получаваме дадени€ exception и неговото съобщение
        try
        {
            _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);
        }
        catch (InvalidOperationException ex)
        {
            Assert.That(ex.Message, Is.EqualTo("User must be logged in to perform this operation."));
        }
    }

    //Task 5
    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Arrange
        string input = "8";
        int expected = 8;

        //Act
        int result = _exceptions.FormatExceptionParseInt(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 5
    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        //Arrange
        string input = "Desi"; //текст, който не може да се преобразува в ц€ло число

        //Act & Assert
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());
        Assert.That(() => _exceptions.FormatExceptionParseInt("5.5"), Throws.TypeOf<FormatException>());
        Assert.That(() => _exceptions.FormatExceptionParseInt("5a"), Throws.TypeOf<FormatException>());

    }

    //Task 6
    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["Alex"] = 1,
            ["Bobi"] = 2,
            ["Viktor"] = 3,
            ["Georgi"] = 4
        };
        string key = "Viktor";
        int expected = 3;

        //Act
        int result = _exceptions.KeyNotFoundFindValueByKey(dict, key);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 6
    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            ["Alex"] = 1,
            ["Bobi"] = 2,
            ["Viktor"] = 3,
            ["Georgi"] = 4
        };
        string key = "Desi";

        //Act & Assert
        Assert.That(() => _exceptions.KeyNotFoundFindValueByKey(dict, key), Throws.InstanceOf<KeyNotFoundException>());

    }

    //Task 7
    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        int a = 5;
        int b = 10;
        int expected = 15;

        //Act
        int result = _exceptions.OverflowAddNumbers(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 7
    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MaxValue; //2,147,483,647
        int b = 100;

        //Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());
    }

    //Task 7
    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MinValue; //-2,147,483,648
        int b = -100;
        //-2,147,483,648 + (-100) = -2,147,483,748

        //Act & Assert
        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());
    }

    //Task 8
    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange
        int divident = 8;
        int divisor = 4;
        int expected = 2;

        //Act
        int result = _exceptions.DivideByZeroDivideNumbers(divident, divisor);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 8
    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        //Arrange
        int divident = 8;
        int divisor = 0;
        string expectedExceptionMessage = "Division by zero is not allowed.";

        //Act & Assert
        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(divident, divisor), Throws.TypeOf<DivideByZeroException>());

        try
        {
            _exceptions.DivideByZeroDivideNumbers(divident, divisor);
        }
        catch (DivideByZeroException ex)
        {
            Assert.That(ex.Message, Is.EqualTo(expectedExceptionMessage));
        }
    }

    //Task 9
    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
        int index = 2;
        int expected = 15; //сумата на числата в масива

        //Act
        int result = _exceptions.SumCollectionElements(numbers, index);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 9
    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange
        int[] numbers = null;
        int index = 2;

        //Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(numbers, index), Throws.TypeOf<ArgumentNullException>());
    }

    //Task 9
    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] numbers = { 10, 20, 30, 40, 50 };
        //валидни позиции: [0, 4]

        //Act & Assert
        Assert.That(() => _exceptions.SumCollectionElements(numbers, -2), Throws.TypeOf<IndexOutOfRangeException>());
        Assert.That(() => _exceptions.SumCollectionElements(numbers, 10), Throws.TypeOf<IndexOutOfRangeException>());
        Assert.That(() => _exceptions.SumCollectionElements(numbers, 5), Throws.TypeOf<IndexOutOfRangeException>());

    }

    //Task 10
    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["Desi"] = "5",
            ["Ivan"] = "8",
            ["Pesho"] = "3"
        };
        string key = "Desi";
        int expected = 5;

        //Act
        int result = _exceptions.GetElementAsNumber(dict, key);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    //Task 10
    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["Desi"] = "one",
            ["Ivan"] = "two",
            ["Pesho"] = "three"
        };
        string key = "Aleks";

        //Act & Assert
        Assert.That(() => _exceptions.GetElementAsNumber(dict, key), Throws.TypeOf<KeyNotFoundException>());
    }

    //Task 10
    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        //Arrange
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            ["Desi"] = "one",
            ["Ivan"] = "two",
            ["Pesho"] = "three"
        };
        string key = "Desi";

        //Act & Assert
        Assert.That(() => _exceptions.GetElementAsNumber(dict, key), Throws.TypeOf<FormatException>());
    }
}