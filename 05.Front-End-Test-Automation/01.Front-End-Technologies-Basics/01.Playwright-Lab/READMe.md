# 🎭 Playwright - Lecture Overview  

## 🌐 1. Web UI Testing Overview  

Web UI testing is the process of verifying that the visual interface of a web application functions correctly. The main goal is to ensure that all elements on the page — buttons, forms, links, and menus — respond properly to user interactions. 🖱️  

These tests usually simulate real interactions with the browser, such as clicking, typing text, and navigating between pages. In this way, both the user experience and the business logic implemented through the interface are validated.  

UI testing can be performed manually or through automation. Automated testing allows fast and consistent execution of a large number of tests, which is especially useful when code changes frequently or when regression testing is required. ⚙️  

---

## 🧩 2. Introduction to Playwright  

**Playwright** is a web testing automation library developed by Microsoft. It provides a unified API for working with multiple browsers – Chromium, Firefox, and WebKit. Its main purpose is to deliver a reliable and efficient solution for end-to-end testing of modern web applications. 💻  

Playwright supports several programming languages, including JavaScript, TypeScript, Python, Java, and .NET. The tool was designed with a focus on stability, speed, and integration into CI/CD pipelines.  

Key advantages of Playwright include:  
✅ Cross-browser compatibility and parallel test execution  
✅ Support for modern web technologies such as SPAs and dynamic DOM updates  
✅ Ability to run in headless mode  
✅ Capturing screenshots and videos during test execution 🎥  

---

## ⚙️ 3. Playwright Setup  

Playwright installation is done using the Node.js package manager (npm) or the respective manager for the chosen programming language. After project initialization, a base structure is created that includes configuration files, test directories, and resources.  

Example installation via npm:  
```bash
npm init playwright@latest
```  

During setup, the user can choose:  
- the programming language,  
- the testing framework (e.g., Jest or Playwright Test),  
- the browsers to be used for test execution.  

After completing the setup, tests can be run with:  
```bash
npx playwright test
```  

Playwright also provides a graphical interface (**Playwright Test UI**) that allows users to visually review results and debug failed tests. 🧠  

---

## 🧭 4. Working with Playwright  

Working with Playwright is based on the concept of **browser context** and **page**. Each test can start a new context, representing an isolated browser instance that ensures independence between tests.  

A typical test includes the following steps:  
1. Launching the browser and creating a new context  
2. Opening a web page  
3. Performing actions – navigation, filling input fields, clicking buttons  
4. Validating results using assertions  

Playwright provides a rich set of selectors for locating elements — by text, CSS, XPath, or role. This makes it easier to automate testing for different types of web applications. 🔍  

---

## 🧠 5. Playwright Functions  

Playwright offers numerous functions and methods for interacting with elements and controlling the browser. Some of the most commonly used are:  

- **page.goto(url)** – loads a specific URL 🌐  
- **page.click(selector)** – clicks on an element  
- **page.fill(selector, value)** – types text into an input field  
- **page.waitForSelector(selector)** – waits for an element to appear  
- **expect(locator).toHaveText(value)** – verifies element text content  

Additionally, Playwright supports:  
- managing multiple pages or tabs;  
- simulating network requests and responses;  
- working with cookies and local storage;  
- recording user actions and automatically generating test code. 🧩  

---

### 🏁 Conclusion  

Playwright provides a complete ecosystem for automated web application testing. Combining speed, stability, and easy integration, it has become one of the leading solutions for UI testing in modern software development. 🚀
