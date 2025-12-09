# 📘 Selenium WebDriver – Introduction

Selenium WebDriver is the core and most powerful component of the Selenium framework. It provides programmatic control over real browsers and enables stable and flexible UI automation. WebDriver communicates directly with the browser through its native driver, without additional layers, making it faster and more reliable compared to Selenium IDE.

---

## 🚀 1. Selenium WebDriver Overview

Selenium WebDriver is an automation library that enables:

- Browser control through code  
- Simulation of user actions (clicking, typing, navigation, etc.)  
- Working with dynamic content  
- Cross-browser and cross-platform testing  
- Integration with testing frameworks such as NUnit, JUnit, and TestNG  

Supported browsers include:

- Chrome (ChromeDriver)  
- Firefox (GeckoDriver)  
- Edge (EdgeDriver)  
- Safari Driver (macOS only)

---

## 🛠️ 2. Setting Up a C# Project with Selenium + NUnit

### 📌 Required Components

- Visual Studio or JetBrains Rider  
- .NET (6+ recommended)  
- NUnit testing framework  
- Selenium WebDriver  
- Selenium WebDriver Support  
- Browser driver (ChromeDriver is the most common)

### ▶️ Setup Steps

1. Create a new project:  
```
Console App / NUnit Test Project
```

2. Install required NuGet packages:  
```
Selenium.WebDriver
Selenium.Support
NUnit
NUnit3TestAdapter
Microsoft.NET.Test.Sdk
```

3. Download a browser driver matching your browser version.

4. Add it to your project or system PATH.

---

## 🧩 3. Components of a Selenium Test

A typical WebDriver test includes:

### ✔️ Test Fixture  
A class containing tests.

### ✔️ Setup Method  
Initializes WebDriver:
- starts the browser  
- configures implicit/explicit waits  
- prepares the environment  

### ✔️ Test Methods  
Contain the actual test scenarios.

### ✔️ TearDown Method  
Closes the browser and releases resources.

---

## 🧪 First Selenium Test

```csharp
[Test]
public void GoogleSearchTest()
{
 driver.Navigate().GoToUrl("https://www.google.com");
 var input = driver.FindElement(By.Name("q"));
 input.SendKeys("Selenium WebDriver");
 input.Submit();

 Assert.IsTrue(driver.Title.Contains("Selenium"));
}
```
---

## 🎯 4. Locating Elements
WebDriver provides several locator strategies:
### 🔹 Basic Locators
By.Id  
By.Name  
By.ClassName  
By.TagName  

### 🔗 Link Locators
By.LinkText  
By.PartialLinkText  

### 🎨 CSS Selectors
By.CssSelector("#login")  
By.CssSelector(".btn.primary")  
By.CssSelector("input[type='email']")  

### 🧭 XPath Locators
By.XPath("//div[@id='login']")  
By.XPath("//button[contains(text(), 'Submit')]")  

---

## 🔄 5. Working with Dynamic Elements

Dynamic elements change attributes, positions, or visibility during runtime.
Key techniques include:
- Using explicit waits (WebDriverWait)
- Targeting stable attributes
- Using contains() in CSS/XPath
- Waiting for visibility or clickability
- Retry logic for rapidly changing DOMs

Example:
```
var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
var button = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("start")));
button.Click();
```

--- 

## 👻 6. Headless Browsers
Headless browsers run without a visible UI.
They are commonly used for:
- CI/CD pipelines
- Cloud testing
- Fast smoke tests
- Environments without graphical interfaces
Example (Chrome headless):
```
var options = new ChromeOptions();
options.AddArgument("--headless");

var driver = new ChromeDriver(options);
```

---

## 🎉 Conclusion
Selenium WebDriver provides a powerful foundation for building stable, scalable, and professional UI automation. Understanding locators, dynamic elements, and headless mode is essential for developing reliable automated test architectures.
