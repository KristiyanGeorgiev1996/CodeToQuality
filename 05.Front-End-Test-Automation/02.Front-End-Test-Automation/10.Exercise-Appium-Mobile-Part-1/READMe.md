# 🤖 Mobile Test Automation – Summator & ColorNote Apps

## 📄 Overview

This project demonstrates **mobile test automation** for two Android applications:  

1. **Summator App** – a simple calculator app  
2. **ColorNote App** – a notepad app for creating, editing, and deleting notes  

The tests are built using **C#**, **NUnit**, and **Appium**, following the **Page Object Model (POM)** design pattern.  

Goals of this project:  

- Automate UI testing on Android emulators/devices  
- Implement **POM** for clean, reusable code  
- Test **valid and invalid inputs** in Summator  
- Test **CRUD operations** in ColorNote  
- Demonstrate proper **Appium setup and teardown**  

---

## 🚀 Features

### **Summator App**
- ✅ Test valid inputs – assert correct sum  
- ✅ Test invalid inputs – assert `"error"` message  
- ✅ POM implementation for cleaner test code  
- ✅ Reusable setup and teardown with Appium server  

### **ColorNote App**
- ✅ Create a new text note  
- ✅ Edit an existing note  
- ✅ Delete a note  
- ✅ Handle optional tutorial screens  
- ✅ POM implementation for maintainable tests  
- ✅ Supports future expansion for more test scenarios  

---

## 📂 Project Structure

```
MobileAutomationProject/
│
├─ Summator/
│ ├─ SummatorPOM.cs # Page Object Model class for Summator
│ └─ CalculatorTests.cs # NUnit test class for Summator POM
│
├─ ColorNote/
│ ├─ ColorNotePage.cs # Page Object class for main ColorNote screen
│ ├─ NoteEditorPage.cs # Page Object class for note editing/creation
│ └─ ColorNoteTests.cs # NUnit test class for ColorNote app
│
├─ AppiumSetup/
│ └─ SetupAndTeardown.cs # Optional common setup/teardown code
│
└─ Packages/
├─ Appium.WebDriver
└─ NUnit
```

---

## ⚙️ Appium & Android Setup

1. **Start Appium Server**  
   - Local server on `127.0.0.1:4723` using `AppiumServiceBuilder`  
   - Appium Inspector can be used to verify element IDs  

2. **Android Emulator (AVD)**  
   - Launch your AVD before running tests  
   - Ensure the `.apk` files are installed on the emulator  

3. **Desired Capabilities Example**  
```text
automationName: UIAutomator2
platformName: Android
platformVersion: <your version>
deviceName: <emulator or device name>
app: Path to .apk file
appium:autoGrantPermissions: true  # For ColorNote app
```

---

## 🧩 Page Object Model (POM)

### **Summator POM**
- Encapsulates elements: `Field1`, `Field2`, `ButtonCalc`, `Result`  
- Encapsulates actions: `Calculator(num1, num2)` method  
- Reduces code duplication in tests  

### **ColorNote POM**
- Encapsulates screens: `ColorNotePage`, `NoteEditorPage`  
- Common actions: Create, Edit, Delete note  
- Handles optional tutorial screens gracefully  

---

## 🧪 NUnit Test Structure

### **Summator Tests**
| Test Name             | Description                                           |
|-----------------------|-------------------------------------------------------|
| **Test_ValidData_Pom**   | Verifies the sum of two valid numbers is correct |
| **Test_InvalidData_Pom** | Verifies that invalid input returns `"error"`   |

### **ColorNote Tests**
| Test Name           | Description                                           |
|--------------------|-------------------------------------------------------|
| **Test_CreateNote** | Creates a new note titled "Test_1" and verifies it |
| **Test_EditNote**   | Edits note "Test_2" to "Edited" and verifies update |
| **Test_DeleteNote** | Deletes note "Note for Delete" and verifies deletion |

- `[OneTimeSetUp]` initializes **Appium server** and **AndroidDriver**  
- `[OneTimeTearDown]` cleans up resources after tests  
- `[Test]` attributes define individual test cases  

---

## 🌟 Project Highlights

- Full automation of **real Android apps** on emulator/device  
- **Reusable setup and teardown** methods for clean test runs  
- Follows **Page Object Model (POM)** for maintainable code  
- Explicit handling of input fields using `.Clear()` before `.SendKeys()`  
- Demonstrates **error handling** and **CRUD operations** in mobile UI testing  
- Easy to extend with additional test scenarios  

---

## 📌 Notes

- Tests mirror exactly what happens on the emulator  
- **NUnit** ensures clean and readable test reports  
- Can be adapted for **physical Android devices** or **CI/CD pipelines**  
- For ColorNote, `appium:autoGrantPermissions` ensures smooth automation without permission popups  

---

## 📖 References

- [Appium Documentation](https://appium.io/docs/en/about-appium/intro/)  
- [Appium C# Client](https://github.com/appium/appium-dotnet-driver)  
- [NUnit Documentation](https://docs.nunit.org/)  
- [Summator App GitHub](https://github.com/nakov/AndroidApp-Summator)  
- **ColorNote App APK** – provided in exercise resources  

---

💡 **Tip:** Extend your tests by covering more invalid inputs, testing additional UI elements, or adding cross-device verification for full coverage.
