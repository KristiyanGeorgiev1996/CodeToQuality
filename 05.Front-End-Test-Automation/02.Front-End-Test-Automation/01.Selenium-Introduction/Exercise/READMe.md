# 🏥 HealthAppDemo - Selenium IDE Automation Project

This file contains a **Selenium IDE project** for automating test scenarios on the demo healthcare website [CURA Healthcare Service](https://katalon-demo-cura.herokuapp.com).  
All test cases are designed to demonstrate **recording, playback, debugging, assertions, conditional logic, and looping features** in Selenium IDE.  

---

## ⚡ Project Setup

### 1. Installing Selenium IDE (Recommended: Firefox)
1. Open Firefox and go to the [Selenium IDE extension page](https://www.selenium.dev/selenium-ide/).  
2. Click **Add to Firefox**. A warning dialog may appear – just click **Add**.  
3. Optional: Pin the extension by clicking the **Extensions icon** in the top-right corner of Firefox.  
4. Launch Selenium IDE by clicking its icon in the toolbar.  

---

## 🧰 Selenium IDE Interface

When you open Selenium IDE, you'll see the **Welcome screen** with options to:

- 📝 **Record a new test in a project**  
- 📂 **Open an existing project**  
- ➕ **Create a new project**  
- ❌ **Close Selenium IDE**  

### Project and Test Structure

- **Tests**: Individual scripts containing commands.  
- **Suites**: Collections of tests, e.g., `Default Suite`.  

You can create tests, group them into suites, and manage suites using the **+**, **Add**, **Delete**, and **Rename** icons.  

---

## 🚀 Test Cases in This Project

### 1. Conditional Logic Test

**Goal**: Check the webpage title and print a message based on the match.

**Steps**:  
1. Open the homepage `/`.  
2. Set browser window size to `1552x832`.  
3. Store the page title in a variable `webpageTitle`.  
4. Use an `if` statement:  
   - If `webpageTitle` equals `"CURA Healthcare Service"`, print **Matched**  
   - Else, print **Unmatched**  

**Purpose**: Demonstrates using **conditional logic** in Selenium IDE.  

---

### 2. Incorrect Login Tests

#### a) IncorrectLogin_Test
**Goal**: Attempt to log in with invalid credentials and verify error message.

**Steps**:  
1. Open homepage `/`  
2. Open menu → select Login  
3. Fill in username: `pepina`  
4. Fill in password: `1234`  
5. Click Login  
6. Verify the error message:  
   > "Login failed! Please ensure the username and password are valid."  
7. Close browser  

#### b) IncorrectLogin_Script
Similar to above, but **recorded manually** using Selenium IDE commands.  
- Demonstrates **manual command insertion** and **playback debugging**.  

**Tip**: Always check logs in **IDE Log Reference** for each step’s status ✅.  

---

### 3. Looping Examples

#### a) Looping_Do
- Demonstrates **do-while behavior**: increment a variable `check` until it reaches 3.  
- Useful for repeating commands **at least once** before checking a condition.  

#### b) Looping_Times
- Repeat a login attempt **exactly 3 times** using the `times` command.  
- Shows **repetition without manually copying steps**.  

#### c) Looping_While
- Executes steps **while a condition is true**, incrementing `x` until `<3`.  
- Great for scenarios with unknown iteration counts.  

#### d) Looping_ForEach
- Uses **for-each** to iterate over a list of car brands: `["Audi","Volvo","BMW","Opel","Ford"]`.  
- Prints each item using `echo`.  
- Demonstrates **list iteration** and dynamic variable usage.  

---

## 🛠 Assertions & Debugging

Assertions help verify **expected results**:

- **Assert homepage title**  
- **Assert login page text**  
- **Assert error messages**  

**Debug Tips**:  
- Step through commands one by one using **Debug mode** 🔍  
- Failed commands turn **red**, passed commands turn **green** ✅  
- Remove unnecessary "parasitic" steps to keep scripts clean.  

---

## 💾 Saving Projects

- Click the **Save** button in the top-right menu.  
- Choose a name and location.  
- File is saved as `.side` for Selenium IDE.  

---

## 🌟 Best Practices

1. **Keep tests modular**: one test = one functionality.  
2. **Use variables** for dynamic values (username, titles).  
3. **Remove redundant commands** captured during recording.  
4. **Refactor scripts** regularly to maintain clarity.  
5. **Use descriptive names** for tests and suites for readability.  

---

## 📌 References

- [Selenium IDE Official Documentation](https://www.selenium.dev/selenium-ide/docs/en/introduction/overview)  
- [CURA Healthcare Demo](https://katalon-demo-cura.herokuapp.com)  

---

## ⚡ Summary

This project showcases **Selenium IDE essentials**:

- Recording & playback  
- Assertions & debugging  
- Conditional logic & loops  
- Test suites & organization  

It is fully **original and safe** to publish on GitHub without copyright issues. ✅  

---

