# 📘 Selenium Page Object Model (POM)

Page Object Model (POM) is a design pattern used in web automation to **improve maintainability, readability, and reusability of test scripts**. It separates test logic from UI interactions by representing each page or component as a class.

---

## 🏷 1. What is Page Object Model (POM)

POM converts each web page into an object. Each object contains:

- **Locators** (page elements)  
- **Methods** to perform actions on elements  
- **Properties** to retrieve information from the page  

**Main benefits:**

- Easier test maintenance  
- Code reusability  
- Reduced duplication  
- Clear structure for larger projects  
- Seamless integration with frameworks like NUnit or MSTest

---

## 🛠 2. Creating Page Object Classes in C#

### Example project structure:
```
/SeleniumProject
/Drivers
/Pages
LoginPage.cs
DashboardPage.cs
/Tests
LoginTests.cs
/Utils
```

### Example LoginPage class:

```csharp
using OpenQA.Selenium;

namespace SeleniumProject.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        // Constructor
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators
        private IWebElement UsernameInput => driver.FindElement(By.Id("username"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        // Methods
        public void EnterUsername(string username)
        {
            UsernameInput.Clear();
            UsernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }

        public void ClickLogin()
        {
            LoginButton.Click();
        }

        public void LoginAs(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}
```

---

## 🧪 3. Unit Tests with Page Objects
Page Object classes allow clean and maintainable tests.
Example NUnit test:
```
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.Pages;

namespace SeleniumProject.Tests
{
    public class LoginTests
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://example.com/login");
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void ValidLoginTest()
        {
            loginPage.LoginAs("testuser", "password123");
            Assert.IsTrue(driver.Title.Contains("Dashboard"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
```

---

## 📂 4. Practice: Structuring a Selenium Project with Page Objects

### Steps to build a project:

1. Create a **Pages** folder and place Page Object classes there.  
2. Create a **Tests** folder for test scenarios.  
3. Use constructors to inject WebDriver into Page Object classes.  
4. Organize helper classes and utilities in a **Utils** folder.  
5. Use Page Object methods in tests for actions and assertions.

### Best practices:

- Each test uses its own Page Object instance  
- Locators and methods should not be duplicated across tests  
- Use Explicit Waits in Page Object methods when necessary  
- Tests should contain only business logic, not direct element interactions

---

# 🎉 Conclusion

Page Object Model (POM) improves test automation by **separating UI interactions from test logic**, making tests more maintainable, reusable, and readable. Following POM principles is essential for professional and scalable Selenium automation frameworks.
