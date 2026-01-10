# 🧪 Selenium Automation Portfolio – QA Practice

Welcome to my **Selenium Automation Portfolio**, showcasing automated UI tests written in **C#** using **Selenium WebDriver** and **NUnit**.  
This repository includes a variety of test scenarios, covering basic web interactions, form submissions, locator strategies, assertions, and headless browser execution. ✅

---

## 1️⃣ Wikipedia QA Search – Console App

This project demonstrates basic **Selenium WebDriver usage** in a simple Console App.  

**What it does:**

- Launches Chrome browser and navigates to **Wikipedia** 🌐
- Prints the main page title to the console 🖨️
- Locates the search input and focuses on it
- Types **"Quality Assurance"** and presses **Enter**
- Prints the title of the search results page
- Closes the browser 🏁

**Skills demonstrated:**

- Selenium WebDriver basics
- Element interaction (`Click()`, `SendKeys()`)
- Console output
- Browser lifecycle management

---

## 2️⃣ First Web Test – Nakov.com Site

This NUnit test project shows **structured test automation** with setup and teardown routines.  

**Scenario:**

- Navigate to [Nakov.com](https://nakov.com)
- Verify the page title contains `"Svetlin Nakov – Official Web Site"` ✅
- Locate the **search link** and check its text contains `"SEARCH"` 🔍
- Click the search link
- Verify the search input’s `placeholder` attribute is `"Search this site"`  
- Close the browser after test completion

**Skills demonstrated:**

- NUnit test structure (`[SetUp]`, `[TearDown]`, `[Test]`)
- Web element verification
- Assertions on text and attributes
- Structured test automation

---

## 3️⃣ Practice Locators – SimpleForm

This project focuses on practicing **element locating techniques** in Selenium.  

**Resources:**  
- `Locators.html`  
- `ThankYou.html`  

**Test scenarios include:**

### 3.1 Basic Locators
- Find elements by **ID**, **Name**, **Tag Name**, and **Class Name**
- Example: Last name input, newsletter checkbox, anchor links, and information fields

### 3.2 Text Link Locators
- Locate links using **full text** and **partial text**

### 3.3 CSS Selectors
- Find elements using ID, Name, Class, and more specific CSS selectors

### 3.4 XPath Locators
- Practice both **absolute** and **relative XPath** expressions

**Skills demonstrated:**

- Locating elements with multiple strategies
- Understanding DOM structure
- Preparing for robust test automation

---

## 4️⃣ Extended Locators – Assertions Added

This version adds **assertions** to validate element states and attributes:

- Verify **Last Name** value  
- Ensure **Newsletter** checkbox is unchecked  
- Check anchor tag text and link URLs  
- Validate background color of elements  
- Confirm CSS selectors and XPath elements are correct and displayed  

**Skills demonstrated:**

- Combining locators with **assertions**  
- Verifying web element states (`Selected`, `Displayed`)  
- CSS & XPath verification

---

## 5️⃣ Form Submission Automation

Automates filling and submitting a contact form:

**Steps:**

1. Verify the **Contact Form** title 📝  
2. Select **male radio button** and assert selection  
3. Enter `"Butch"` in First Name and `"Coolidge"` in Last Name  
4. Verify **Additional Information** section exists  
5. Enter phone number `"0888999777"`  
6. Check the **newsletter checkbox**  
7. Submit the form  
8. Verify the **Thank You!** message appears on the confirmation page 🎉

**Skills demonstrated:**

- Form interaction and data entry  
- Assertions on input values and element states  
- Page navigation verification

---

## 6️⃣ Headless Browser Execution

- Some tests are executed in **headless mode** 🕶️
- Compare execution time with standard browser mode  
- Useful for **CI/CD pipelines** and **faster test runs**

**Skills demonstrated:**

- ChromeOptions configuration  
- Headless testing  
- Performance-aware automation

---

## 🔧 Technologies & Tools Used

- **C#**  
- **Selenium WebDriver**  
- **ChromeDriver**  
- **NUnit**  
- **Visual Studio 2022**  

---

## 📁 Repository Structure

```text
Selenium-Automation-Portfolio/
│
├── ConsoleApps/
│   └── WikipediaSearch/
│
├── NUnitTests/
│   ├── FirstTest/
│   ├── Locators/
│   ├── LocatorsWithAssertions/
│   └── TestFormSubmission/
│
├── .gitignore
└── README.md
```

---

## 🚀 Key Takeaways
- Solid understanding of Selenium locators
- Using NUnit for structured tests
- Practice with form submission, assertions, and headless mode
- Organized QA portfolio-ready projects

---

## ✨ Notes
- HTML test files are included for practice only
- Console apps show basic Selenium automation
- Tests demonstrate professional QA skills, ready for interviews 💼

