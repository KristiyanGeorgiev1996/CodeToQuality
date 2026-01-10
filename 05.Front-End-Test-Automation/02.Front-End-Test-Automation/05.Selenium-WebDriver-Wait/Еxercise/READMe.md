# 🌐 Selenium Dynamic Elements and Waits

This project demonstrates how to interact with **dynamic web elements** using Selenium WebDriver in C#. It focuses on understanding the behavior of elements that appear or change after user actions, and how different types of waits can be applied to handle them effectively.  

---

## 🎯 Objectives

- Explore what happens when **elements are not immediately available** on a page.  
- Learn the difference between **implicit, explicit, and fluent waits**.  
- Apply waits to ensure elements are ready before interaction.  
- Practice handling exceptions caused by dynamic content.  

---

## ⚙️ Prerequisites

- NUnit Test Project (.NET Core).  
- Selenium packages installed via NuGet:  
  - `Selenium.WebDriver`  
  - `Selenium.WebDriver.ChromeDriver`  
  - `Selenium.Support`  
  - `SeleniumExtras.WaitHelpers` (for expected conditions)  

- Chrome browser installed.  
- Basic knowledge of locating web elements using `By` strategies.  

All tests are performed on the URL: [https://www.selenium.dev/selenium/web/dynamic.html](https://www.selenium.dev/selenium/web/dynamic.html)

---

## 📝 Tests Overview

### 1️⃣ Tests Without Waits

Elements might not appear immediately, causing failures.  

#### `AddBoxWithoutWaitsFails`
- Click the **Add Box** button.  
- Attempt to locate the new box element immediately.  
- ✅ Assert that a `NoSuchElementException` is thrown.

#### `RevealInputWithoutWaitsFail`
- Click the **Reveal Input** button.  
- Attempt to find and type into the hidden input.  
- ✅ Assert that an `ElementNotInteractableException` is thrown.  

> ⚠️ These tests intentionally demonstrate failures caused by **dynamic content loading** without waits.

---

### 2️⃣ Using Thread.Sleep

#### `AddBoxWithThreadSleep`
- Click **Add Box**.  
- Wait a fixed 3 seconds using `Thread.Sleep`.  
- Locate the new box element after the delay.  
- ✅ Assert that the box is displayed.  

> ❌ Using `Thread.Sleep` is inefficient and can slow down tests, but it guarantees a simple delay.

---

### 3️⃣ Implicit Waits

Implicit waits tell Selenium to **poll for elements up to a defined timeout** before throwing an exception.

#### `AddBoxWithImplicitWait`
- Set `ImplicitWait` to 10 seconds.  
- Click **Add Box**.  
- Attempt to locate the new box element.  
- ✅ Assert that it is displayed.

#### `RevealInputWithImplicitWaits`
- Set `ImplicitWait` to 10 seconds.  
- Click **Reveal Input**.  
- Find the input element.  
- ✅ Assert that the element exists and is an `<input>` tag.

> ✅ Implicit waits are **global**, affecting all element searches in the WebDriver session.

---

### 4️⃣ Explicit Waits

Explicit waits allow **waiting for specific conditions** on certain elements.

#### `RevealInputWithExplicitWaits`
- Click **Reveal Input**.  
- Use `WebDriverWait` to wait until the element is **visible**.  
- Send keys to the input field.  
- ✅ Assert that the value is set correctly.  

> 🔹 Explicit waits are **element-specific**, providing more control than implicit waits.

---

### 5️⃣ Fluent Wait with Expected Conditions

Fluent Waits combine **timeouts, polling intervals, and ignored exceptions**.

#### `AddBoxWithFluentWaitExpectedConditionsAndIgnoredExceptions`
- Click **Add Box**.  
- Configure `WebDriverWait` with:  
  - Timeout: 10 seconds  
  - Polling interval: 500 ms  
  - Ignored exceptions: `NoSuchElementException`  
- Wait until the new box is **visible** using `ExpectedConditions`.  
- ✅ Assert that the box is displayed.  

> 🔹 Fluent Wait is highly flexible for **dynamic content** that loads irregularly.

---

### 6️⃣ Custom Wait Conditions

Custom conditions allow **complex logic** beyond predefined expected conditions.

#### `RevealInputWithCustomFluentWait`
- Click **Reveal Input**.  
- Configure `WebDriverWait`:  
  - Timeout: 5 seconds  
  - Polling interval: 200 ms  
  - Ignored exception: `ElementNotInteractableException`  
- Use a **lambda function** in `wait.Until` to attempt sending keys until the input is interactable.  
- ✅ Assert the input element is displayed and the value is correct.  

> 🔹 Custom waits provide **full control** for unique scenarios.

---

### 7️⃣ Handling Exceptions

The first two tests validate exception handling for dynamic elements:

- `AddBoxWithoutWaitsFails` → `NoSuchElementException`  
- `RevealInputWithoutWaitsFail` → `ElementNotInteractableException`  

This demonstrates how Selenium handles elements that are not yet ready.

---

## 💡 Best Practices

1. Prefer **Explicit or Fluent waits** over `Thread.Sleep`.  
2. Use **Implicit waits** carefully; they are global and affect all element searches.  
3. Fluent waits are ideal for **elements that appear irregularly**.  
4. Custom wait conditions are perfect for **complex or unique UI behavior**.  
5. Always handle exceptions gracefully to ensure **stable test execution**.  

---

## 🛠️ Technologies Used

- C# (.NET Core)  
- NUnit  
- Selenium WebDriver  
- ChromeDriver  
- SeleniumExtras.WaitHelpers  

---

## 🏁 Conclusion

This project showcases the **importance of waits** when dealing with dynamic web elements. Understanding the difference between **implicit, explicit, and fluent waits** allows for reliable test execution and robust interaction with elements that are loaded or displayed asynchronously.

---

