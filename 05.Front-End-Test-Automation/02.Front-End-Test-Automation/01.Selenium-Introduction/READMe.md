# 🚀 Selenium Introduction

## 1. 🔍 What Is Selenium?
Selenium is a popular open-source platform for automating web applications. It simulates real user interactions within the browser such as clicking, typing, navigating, and validating UI components.

Selenium consists of several core components:

- **Selenium WebDriver** – 🧠 an API that communicates directly with the browser  
- **Selenium IDE** – 🎥 a record-and-playback tool for quick test creation  
- **Selenium Grid** – 🌐 a system for distributed and parallel test execution  

🎯 Key objectives:
- Automate web UI functional tests  
- Support all modern browsers  
- Work across multiple operating systems  
- Allow test creation in various programming languages (Java, C#, Python, JS, etc.)

---

## 2. 🧰 Selenium IDE Introduction
**Selenium IDE** is a browser extension (Chrome/Firefox) that enables automatic recording and execution of test scenarios using a **record & playback** mechanism.

### ⭐ Key capabilities:
- 🎬 Recording user actions  
- ✏️ Visual editing of test steps  
- ✔️ Support for assertions  
- 🔄 Exporting tests to WebDriver code  

➡️ Ideal for quick tests, learning, and smoke testing.

---

## 3. ⚙️ Key Features and Processes

### ⭐ Core functionalities:
- 🌍 Cross-browser automation  
- 💻 Cross-platform support  
- 🧩 Multiple programming languages  
- 🔗 Easy CI/CD integration  
- 📊 Suitable for functional, regression, and data-driven testing  

### 🔄 Selenium IDE workflow:
1. ▶️ Launch the IDE  
2. 📁 Create a Test Suite and Test Case  
3. 🎬 Record user interactions  
4. ✏️ Edit recorded steps  
5. ✔️ Add assertions  
6. ▶️ Execute the test  
7. 📊 Review test results  
8. 🔄 Export to WebDriver (optional)

---

## 4. 💾 Installation, 🖥 UI, 📂 Managing Tests and Suites

### 🛠 Installation steps:
1. 🔎 Open Chrome Web Store or Firefox Add-ons  
2. 🧩 Search for **Selenium IDE**  
3. ⬇️ Install it  
4. 🚀 Start it from the browser toolbar  

### 🖥 Main UI components:
- 📂 **Test Explorer** – lists suites and cases  
- ✏️ **Editor Panel** – shows test commands  
- 🎯 **Target Selector** – helps choose locators  
- 🎛 **Control Toolbar** – start/stop/play controls  

### 📂 Managing tests:
- ➕ Create Test Suites  
- 📝 Add or edit Test Cases  
- 🔄 Reorder and group cases  
- 🗑️ Delete test items  

---

## 5. ✍️ Writing Scripts
Selenium IDE can generate tests automatically through recording, but also supports manual creation of command steps.

📌 Each step contains:
- **command**
- **target**
- **value**

📘 Example:
```
open | /login |
type | id=username | test_user
type | id=password | secret123
click | id=login-button |
assertText | css=h1 | Welcome
```

🔎 Common locator types:
- ID  
- Name  
- CSS Selector  
- XPath  

💡 Best practices:
- Use stable and unique locators  
- Add meaningful assertions  
- Structure test cases logically  

---

## 6. 🧪 Selenese
**Selenese** is the command language used by Selenium IDE to define test actions and validations.

### 🔧 Selenese command categories:

#### 1. ⚡ Actions  
Execute interactions:
- `click`
- `type`
- `select`
- `submit`

#### 2. ✔️ Assertions  
Validate UI states:
- `assertText`
- `assertElementPresent`
- `assertTitle`

#### 3. 📥 Accessors  
Retrieve and store information:
- `storeText`
- `storeValue`
- `storeAttribute`

🧩 Command structure:
```
command | target | value
```

---

## 7. 🚀 Selenium IDE Advanced

### 🔁 Control Flow Commands
Allow logical branching:
- `if`, `else if`, `else`
- `while`
- `repeat until`
- `forEach`

Example:
```
if | ${isLoggedIn} == false
click | id=login
end
```

### 🧮 Working with Variables:
```
storeText | id=user-name | username
assert | ${username} | test_user
```

### 📊 Data-Driven Testing:
Supports:
- CSV  
- JSON  
- Arrays of data  

### 🔌 Plugins:
Extend IDE capabilities:
- Improved locator handling  
- Framework integrations  
- Visual validations  

### 🔄 Export to WebDriver:
Supports exporting to:
- Java  
- C#  
- Python  
- JavaScript  

Allows transitioning from beginner IDE tests to professional automation frameworks.

---
