# 🛒 Selenium WebDriver Test Automation – Swag Labs

## 📄 Overview

This project demonstrates **end-to-end test automation** for the demo e-commerce website **Swag Labs** ([https://www.saucedemo.com](https://www.saucedemo.com)) using **Selenium WebDriver** and **C#**.  

The main goal is to showcase the **Page Object Model (POM) design pattern**, **reusable test structures**, and **automated UI testing** for typical e-commerce workflows: login, browsing products, managing the shopping cart, and completing checkout.

---

## 🚀 Features

- ✅ **Login automation** with valid, invalid, and locked-out users  
- ✅ **Product management**: view products, add items to the cart by index or name  
- ✅ **Cart operations**: verify added items, proceed to checkout  
- ✅ **Checkout process**: enter user information, complete orders  
- ✅ **Hidden menu actions**: open menu, logout  
- ✅ **Reusable base classes** for WebDriver setup, element interactions, and waits  

---

## 📂 Project Structure

SwagLabsAutomation/
│
├─ Base/
│ ├─ BasePage.cs # Common page actions: click, type, find element(s), get text
│ └─ BaseTest.cs # WebDriver setup/teardown, reusable login
│
├─ Pages/
│ ├─ LoginPage.cs
│ ├─ InventoryPage.cs
│ ├─ CartPage.cs
│ ├─ CheckoutPage.cs
│ └─ HiddenMenuPage.cs
│
├─ Tests/
│ ├─ LoginPageTests.cs
│ ├─ InventoryPageTests.cs
│ ├─ CartPageTests.cs
│ ├─ CheckoutPageTests.cs
│ └─ HiddenMenuPageTests.cs
│
└─ Packages/
└─ NuGet dependencies:
- Selenium.WebDriver
- Selenium.Support
- Selenium.WebDriver.ChromeDriver
- SeleniumExtras.WaitHelpers


---

## 🧩 Pages & Functionality

### **1️⃣ LoginPage**

Handles authentication and login error messages.

- **Key Actions:**
  - Enter username and password  
  - Click the login button  
  - Retrieve error messages  

### **2️⃣ InventoryPage**

Displays available products and allows adding items to the cart.

- **Key Actions:**
  - Add item to cart by index or name  
  - Verify inventory is displayed  
  - Check page title and URL  

### **3️⃣ CartPage**

Represents the shopping cart and checkout button.

- **Key Actions:**
  - Verify items in the cart  
  - Proceed to checkout  

### **4️⃣ CheckoutPage**

Handles the order completion process.

- **Key Actions:**
  - Enter first name, last name, and postal code  
  - Continue to the next step  
  - Complete the order and verify success message  

### **5️⃣ HiddenMenuPage**

Manages the hidden menu and logout functionality.

- **Key Actions:**
  - Open the hidden menu  
  - Click logout  
  - Verify menu visibility  

---

## 🧪 Tests Overview

| Page | Test Cases |
|------|------------|
| **LoginPageTests** | Valid login, Invalid login, Locked-out user |
| **InventoryPageTests** | Inventory display, Add to cart by index, Add to cart by name, Page title verification |
| **CartPageTests** | Cart item display, Click checkout |
| **CheckoutPageTests** | Page load, Continue to next step, Complete order |
| **HiddenMenuPageTests** | Open menu, Logout |

All tests inherit from **BaseTest** for consistent **WebDriver setup**, **teardown**, and **login flow**.

---

## ⚙️ Technologies & Tools

- **Language:** C#  
- **Framework:** NUnit  
- **Automation Tool:** Selenium WebDriver  
- **Browser:** Chrome (via ChromeDriver)  
- **Design Pattern:** Page Object Model (POM)  
- **Wait Handling:** Explicit waits using SeleniumExtras.WaitHelpers  

---

## 📝 How It Works

1. **Setup:**  
   BaseTest initializes ChromeDriver with options, maximizes the window, and sets implicit wait.  

2. **Login:**  
   Reusable login method simplifies authentication for all tests.  

3. **Page Objects:**  
   Each page class encapsulates locators and methods for interactions, ensuring maintainable and reusable code.  

4. **Test Execution:**  
   Tests call page methods to simulate user actions and verify expected results.  

5. **Teardown:**  
   Browser closes after each test to ensure a clean state.  

---

## 🌟 Project Highlights

- Full **end-to-end coverage** from login to checkout  
- **Reusable BasePage and BaseTest** classes reduce code duplication  
- Follows **best practices** in test automation design  
- Easy to extend for additional pages or test scenarios  

---

## 📌 Notes

- The project avoids hard-coded waits by using **explicit waits** for stability  
- Locators are carefully designed for maintainability (ID, CSS Selector, Class Name)  
- Each test is **isolated** and independent, allowing parallel execution if needed  

---

## 📖 References

- [Selenium WebDriver Documentation](https://www.selenium.dev/documentation/)  
- [NUnit Documentation](https://docs.nunit.org/)  
- [Swag Labs Demo](https://www.saucedemo.com/)  

---

💡 **Tip:** The project can be extended with tests for filtering products, removing items from the cart, or cross-browser testing.  
