# 🤖 Appium Mobile Test Automation – Summator Android App

## 📄 Overview

This project demonstrates **mobile test automation** for the **Summator Android app** ([GitHub Repository](https://github.com/nakov/AndroidApp-Summator)) using **Appium** and **C# NUnit**.  

The goal is to showcase **automated UI testing** on Android emulators/devices, including **valid and invalid input scenarios**, proper setup of Appium server, and reusable test structures.  

---

## 🚀 Features

- ✅ Automated testing of **Summator Android app**  
- ✅ Tests with **valid numeric inputs** to assert correct sum  
- ✅ Tests with **invalid inputs** to assert error handling  
- ✅ Full **Appium server setup and teardown**  
- ✅ **AndroidDriver initialization** with UiAutomator2  
- ✅ Clean, maintainable **C# NUnit test structure**  

---

## 📂 Project Structure

```
SummatorAppiumTests/
│
├─ SummatorTests.cs # NUnit test class containing all test methods
├─ Appium setup and teardown
├─ Tests:
│ ├─ Test_ValidData
│ └─ Test_InvalidData
└─ NuGet Packages:
- Appium.WebDriver
- NUnit
```

---

## 🧩 App Functionality Covered

### **1️⃣ Valid Data Test**
- Enter two numbers in the input fields  
- Press the **Calculate** button  
- Assert that the result is correct (sum of two numbers)  

### **2️⃣ Invalid Data Test**
- Enter invalid input (e.g., ".") in the first field  
- Press the **Calculate** button  
- Assert that the result displays `"error"`  

---

## ⚙️ Appium & Android Setup

1. **Start Appium Server**  
   - Local server on `127.0.0.1:4723` using AppiumServiceBuilder  
   - Appium Inspector can be used to verify element IDs  

2. **Android Emulator (AVD)**  
   - Launch your AVD before running tests  
   - Make sure the `.apk` is installed on the emulator  

3. **Desired Capabilities**  
```text
automationName: UIAutomator2
platformName: Android
deviceName: Your emulator/device name
app: Path to Summator .apk
```

4. Element IDs

Get the IDs from **Appium Inspector** for each input field, calculate button, and result field.

---

## 🧪 NUnit Test Structure

| Test Name         | Description                                           |
|------------------|-------------------------------------------------------|
| **Test_ValidData**   | Verifies that the sum of two valid numbers is correct |
| **Test_InvalidData** | Verifies that invalid input returns "error"          |

- `[OneTimeSetUp]` initializes **Appium server** and **AndroidDriver**  
- `[OneTimeTearDown]` cleans up resources after tests  
- `[Test]` attributes define individual test cases  

---

## 🌟 Project Highlights

- Full automation of a **real Android app** on emulator/device  
- **Reusable setup and teardown** methods for clean test runs  
- Explicit handling of input fields using `.Clear()` before `.SendKeys()`  
- Demonstrates **error handling** in mobile UI testing  
- Easy to extend with more test cases or different input scenarios  

---

## 📌 Notes

- The project uses **Appium WebDriver** for mobile automation  
- Test execution mirrors exactly what happens on the emulator  
- **NUnit** ensures clean and readable test reports  
- Can be adapted for **physical Android devices** or **CI/CD pipelines**  

---

## 📖 References

- [Appium Documentation](https://appium.io/docs/en/about-appium/intro/)  
- [Appium C# Client](https://github.com/appium/appium-dotnet-driver)  
- [NUnit Documentation](https://docs.nunit.org/)  
- [Summator App GitHub](https://github.com/nakov/AndroidApp-Summator)  

---

💡 **Tip:** Extend your tests by including more invalid inputs (letters, empty fields) or testing additional UI elements for complete coverage.
