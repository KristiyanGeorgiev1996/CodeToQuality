# 🧪 Selenium Automation Exercises – Advanced Web Interactions

This  tasks contains a set of Selenium exercises focused on dynamic web content, browser windows, alerts, and iFrames. The exercises aim to demonstrate how to handle synchronization issues, interact with multiple browser contexts, and validate web elements effectively.

---

## 0️⃣ Prerequisites

Before running these exercises, ensure the following:

- Create a separate NUnit test project for each exercise.  
- Install the required Selenium packages via NuGet:
  - `Selenium.WebDriver`  
  - `Selenium.WebDriver.ChromeDriver`  
  - `Selenium.Support`  
  - `SeleniumExtras.WaitHelpers` (for ExpectedConditions)  
- Initialize the ChromeDriver and navigate to the corresponding application URLs.  
- Create a test class with proper `[SetUp]` and `[TearDown]` methods.  
- Include necessary namespaces for Selenium and NUnit.

---

## 1️⃣ Searching Products with Implicit Wait ⏳

**Application URL:** [BPB Online](http://practice.bpbonline.com/)  

**Goal:** Learn how implicit waits synchronize tests with dynamically loaded elements.  

**Implementation:**

- **Search for existing product (`keyboard`)**  
  - Use `driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)`  
  - Perform search and click "Buy Now".  
  - Assert that the product appears in the cart page. ✅  

- **Search for non-existing product (`junk`)**  
  - Implicit wait applies but product does not exist.  
  - Assert that `NoSuchElementException` is thrown. ✅  

**Notes:**  
- Implicit wait applies globally to all elements in the session.  
- It waits up to the specified time for an element to appear before throwing an exception.

---

## 2️⃣ Searching Products with Explicit Wait ⏳

**Application URL:** [BPB Online](http://practice.bpbonline.com/)  

**Goal:** Handle dynamic elements with precise control using explicit waits.  

**Implementation:**

- **Search for existing product (`keyboard`)**  
  - Disable implicit wait temporarily (`0 sec`) to avoid conflicts.  
  - Use `WebDriverWait` to wait for the "Buy Now" button.  
  - Click the button and assert that the product is in the cart. ✅  

- **Search for non-existing product (`junk`)**  
  - Disable implicit wait, use explicit wait for "Buy Now".  
  - Assert that `WebDriverTimeoutException` is thrown. ✅  

**Notes:**  
- Explicit wait allows waiting for specific conditions (visibility, clickability).  
- Provides fine-grained control over dynamic content.

---

## 3️⃣ Handling JavaScript Alerts ⚠️

**Application URL:** [The Internet JS Alerts](https://the-internet.herokuapp.com/javascript_alerts)  

**Goal:** Interact with various JS alerts and verify results.  

**Implementation:**

- **Basic Alert**  
  - Trigger alert, accept it, and validate result message. ✅  

- **Confirm Alert**  
  - Accept and dismiss the confirm alert.  
  - Validate the page messages after each action. ✅  

- **Prompt Alert**  
  - Send text input to prompt alert and accept.  
  - Validate the message reflects the entered text. ✅  

**Notes:**  
- Use `driver.SwitchTo().Alert()` to access alerts.  
- Always validate the result message to confirm correct behavior.

---

## 4️⃣ Working with iFrames 🖼️

**Application URL:** [CodePen iFrame Example](https://codepen.io/pervillalva/full/abPoNLd)  

**Goal:** Demonstrate switching between frames and interacting with elements inside them.  

**Implementation:**

- **By Index**  
  - Switch to first iFrame using index.  
  - Click dropdown and extract link texts.  
  - Switch back to default content. ✅  

- **By ID**  
  - Switch using `driver.SwitchTo().Frame("result")`.  
  - Click dropdown, extract links, validate visibility. ✅  

- **By WebElement**  
  - Locate iframe using CSS selector.  
  - Switch using the WebElement reference.  
  - Interact with dropdown links and validate. ✅  

**Notes:**  
- iFrames isolate content; switching is required to interact with elements inside them.  
- Always return to default content after interacting with an iframe.

---

## 5️⃣ Handling Multiple Browser Windows 🌐

**Application URL:** [The Internet Windows](https://the-internet.herokuapp.com/windows)  

**Goal:** Handle multiple windows, switch between them, and manage exceptions.  

**Implementation:**

- **Switch Between Windows**  
  - Click "Click Here" to open a new window.  
  - Switch to new window and verify content.  
  - Log window handles and page contents. ✅  

- **Handle NoSuchWindowException**  
  - Attempt to switch to a closed window.  
  - Catch `NoSuchWindowException` and assert proper handling. ✅  

**Notes:**  
- `driver.WindowHandles` returns all open window IDs.  
- Always switch back to the main window to continue testing.

---

## 🔑 Key Concepts Learned

- **Implicit Waits** – global wait for elements to appear.  
- **Explicit Waits** – conditional wait for specific elements.  
- **WebDriverWait & ExpectedConditions** – precise control for dynamic elements.  
- **Alerts Handling** – JS Alert, Confirm, and Prompt interactions.  
- **iFrames** – switching between frames to interact with isolated content.  
- **Multiple Windows** – switching, logging, and exception handling.  

---

## ✅ Conclusion

These exercises provide a comprehensive understanding of handling dynamic web elements in Selenium, covering waits, alerts, iFrames, and browser windows. Mastery of these topics ensures robust and reliable automation tests in real-world web applications.

---

