# 📱 Appium Testing – Mobile Automation

Appium is an **open-source platform for mobile application automation** supporting both Android and iOS. It allows writing automated tests for mobile apps using familiar programming languages like C#, Java, Python, and JavaScript.

---

## 📲 1. Mobile Testing

Mobile testing focuses on verifying applications on **mobile devices** (phones and tablets).  
Main goals:

- Functional testing of applications  
- UI/UX verification  
- Performance and stability testing  
- Cross-device and OS version testing  

Appium enables **automation of these tests** without modifying the application.

---

## 🛠 2. Appium Introduction

Appium is a **cross-platform** tool that uses the **WebDriver protocol** to automate mobile applications.  
Key features:

- Supports **native, hybrid, and mobile web apps**  
- Works on **Android and iOS**  
- Allows programming in **Java, C#, Python, JavaScript**, and others  
- Does **not require app modification or recompilation**

---

## 🤖 3. Appium for Android App Automation

### 3.1 Basic Appium Setup

1. Install **Appium Desktop**  
2. Install **Node.js** (required by Appium)  
3. Configure **Android SDK** and **ADB**  
4. Set up **Emulator or real device**  

### 3.2 Setup for Android Mobile Testing

- Check Android SDK paths (`ANDROID_HOME`)  
- Install required packages via SDK Manager  
- Launch **Android Emulator** or connect a real device  
- Start Appium Server and configure **Desired Capabilities**  

### 3.3 Android Emulator

- Simulates a physical device on your computer  
- Allows testing without a real device  
- Can configure different Android versions and screen sizes  
- Supports gestures: swipe, tap, scroll, etc.

---

## 🔍 4. Appium Inspector

Appium Inspector is a tool for **visual inspection of mobile apps**:

- Locate **elements and their properties**  
- Generate **locator strategies** for tests  
- Supports **UIAutomator Viewer** for Android  
- Test actions before writing code  

Example actions in Inspector:

- Click a button  
- Enter text in a field  
- Swipe or scroll  
- Verify visibility and element values  

---

## 🧪 5. Testing Demo

Typical Appium test structure:

1. Initialize Appium Driver with Desired Capabilities  
2. Navigate and interact with elements  
3. Perform assertions  
4. End the session  

Example C# code for Android:

```csharp
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

var capabilities = new AppiumOptions();
capabilities.AddAdditionalCapability("platformName", "Android");
capabilities.AddAdditionalCapability("deviceName", "emulator-5554");
capabilities.AddAdditionalCapability("app", @"C:\Apps\MyApp.apk");

var driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);

// Example actions
var loginButton = driver.FindElementById("com.example:id/login");
loginButton.Click();

// Tear down
driver.Quit();
```

---

## 🎉 Conclusion

Appium is a versatile and powerful tool for automating Android and iOS mobile applications.
With Appium, testers can simulate real user interactions, validate UI and functionality, and ensure application stability across devices and platforms. Proper setup, inspector usage, and structured test design are essential for effective mobile automation.
