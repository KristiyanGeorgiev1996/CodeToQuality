# 📝 Selenium UI Automation Exercises  

This project contains automated UI tests for two web applications using **Selenium WebDriver** with **C#** and **NUnit**. The exercises demonstrate key automation concepts such as Page Object Model (POM), implicit and explicit waits, form validation, and handling dynamic content.  

---

## 1️⃣ Sum Two Numbers – Sum-Num App  

An application that sums two numbers. Perfect for practicing Selenium interactions and NUnit assertions.  

### 🔹 How to Run  

**Using a Local Server (Recommended)**  

1. Start a local server with Node.js using the command `npx http-server`  
2. Open your browser and go to `http://localhost:8080`  
3. Click on `sum-num.html` to launch the application  

### 🔹 Page Object – `SumNumberPage`  

Encapsulates all interactions on the Sum Numbers page.  

**Key Elements:**  
- `FieldNum1` – first input field  
- `FieldNum2` – second input field  
- `ButtonCalc` – "Calculate" button  
- `ButtonReset` – "Reset" button  
- `ElementResult` – displays the sum  

**Key Methods:**  
- `OpenPage()` – navigates to the page  
- `AddNumbers(num1, num2)` – fills inputs and clicks "Calculate"  
- `ResetForm()` – resets the form  
- `IsFormEmpty()` – checks if fields and result are empty  

### 🔹 Tests – `SumNumberPageTests`  

**Example Test Cases:**  
- `Test_AddTwoNumbers_ValidInput` – validates the sum of two numbers  
- `Test_AddTwoNumbers_InvalidInput` – handles invalid input gracefully  
- `Test_FormReset` – verifies the reset functionality  

All tests use NUnit assertions to ensure the application behaves as expected ✅  

---

## 2️⃣ Student Registry – StudentsRegistryPOM  

A web application to manage a student registry. Demonstrates **Page Object Model**, dynamic element handling, and form validation.  

### 🔹 Project Structure  

**Page Objects:**  
- `BasePage` – common properties and methods for all pages  
- `HomePage` – landing page, displays the number of registered students  
- `ViewStudentsPage` – lists all students  
- `AddStudentPage` – form for adding new students  

**Test Classes:**  
- `TestHomePage`  
- `TestViewStudentsPage`  
- `TestAddStudentPage`  

### 🔹 BasePage Class  

**Properties & Methods:**  
- `driver` – protected readonly WebDriver  
- `PageUrl` – virtual URL of the page  
- Navigation links: Home, View Students, Add Student  
- Methods:  
  - `Open()` – navigates to the page  
  - `IsOpen()` – verifies the current page  
  - `GetPageTitle()` – retrieves the page title  
  - `GetPageHeading()` – retrieves the main heading  

### 🔹 HomePage  

- Inherits `BasePage`  
- `ElementStudentsCount` – shows the number of registered students  
- `GetStudentsCount()` – retrieves the count programmatically  

### 🔹 ViewStudentsPage  

- Inherits `BasePage`  
- `ListItemsStudents` – list of student elements  
- `GetStudentsList()` – returns an array of student names  

### 🔹 AddStudentPage  

- Inherits `BasePage`  
- Form fields: `FieldStudentName`, `FieldStudentEmail`  
- Button: `ButtonAdd`  
- Error message: `ElementErrorMsg`  
- Methods:  
  - `AddStudent(name, email)` – fills the form and submits  
  - `GetErrorMsg()` – retrieves form error messages  

### 🔹 Test Scenarios  

**Home Page Tests:**  
- Validate page title, heading, and student count  
- Check navigation links  

**View Students Tests:**  
- Validate page content  
- Ensure each student entry is formatted correctly  
- Test navigation links  

**Add Student Tests:**  
- Validate form content and empty fields  
- Add valid students and verify they appear in the view page  
- Add invalid students and verify error messages  

### 🔹 Running the App  

1. Navigate to your project folder:  
   ```text
   cd path\to\project
 ```

2. Install dependencies:
  ```
npm install
```

3. Start the app:
```
npm start
```

4. Open your browser at http://localhost:8080

---

## ✅ Summary

This project includes:

- Selenium WebDriver setup with ChromeDriver
- Use of implicit and explicit waits
- Page Object Model implementation
- Interaction with input fields, buttons, and dynamic elements
- Form validation and error handling
- NUnit test structure

💡 These exercises are excellent for practicing automation fundamentals and preparing for real-world UI testing scenarios.

---

## 📌 Notes

- Elements are located using CSS selectors, IDs, or XPath where appropriate
- Implicit waits are used for general synchronization, explicit waits for dynamic content
- Student test data is generated dynamically to ensure uniqueness
- Assertions are extensively used to verify expected outcomes
