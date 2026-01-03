# 🧪 Selenium IDE Test Scenarios

Automated test cases for web applications using Selenium IDE and exported Selenium WebDriver C# scripts.  

---

## 1️⃣ Number Calculator App

### ✏️ Input Validation
- "First Number" and "Second Number" accept only numeric values.  
- Show error messages for invalid or missing inputs.  
- Test behavior with empty fields.

### 🔢 Operations
- Dropdown allows selection of:  
  - Addition ➕  
  - Subtraction ➖  
  - Multiplication ✖️  
  - Division ➗  

### 🧮 Calculations
- Perform calculations for each operation.  
- Assert correctness of results.

### 🔄 Reset
- Reset button clears all inputs and restores default operation.

### ⚡ Edge Cases
- Division by zero → `"Invalid Calculation"`.  
- Negative numbers, decimals, and spacing in inputs.  
- Handle special values like **Infinity**.

---

## 2️⃣ CURA Health Care Service

### 🦶 Footer Verification
- Check presence of all footer text and elements.

### 🔑 Login & Logout
- Verify login page elements: username, password, instructions.  
- Login with:
  - Username: `John Doe`
  - Password: `ThisIsNotAPassword`  
- Verify post-login navigation.  
- Logout and ensure redirection to login page.

### 📅 Make an Appointment
- Select facility: **Hongkong CURA Healthcare Center**  
- Set Healthcare program: **None**  
- Enter date and comments.  
- Submit and verify all confirmation details:  
  - Facility  
  - Apply for hospital readmission  
  - Healthcare program  
  - Date  
  - Comment  
- Return to homepage and log out.

---

## 3️⃣ SauceDemo Tests

### 🚫 Login with Invalid User
- Enter invalid username → assert error message.  
- Retry with valid credentials:
  - Username: `standard_user`
  - Password: `secret_sauce`  
- Assert successful login → page title `"Products"`.

### 🛒 Add & Remove Items
- Add item to cart → verify cart contents.  
- Remove item → verify cart updates.

---

> These are the required Selenium IDE test scenarios and validations.
