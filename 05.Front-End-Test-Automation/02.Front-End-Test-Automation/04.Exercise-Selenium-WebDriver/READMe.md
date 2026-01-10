# 🖥️ Working with Web Elements and Number Calculator

This tasks contains solutions for interacting with various web elements using **Selenium WebDriver (C#)**. It includes exercises with forms, tables, dropdown elements, and the "Number Calculator" application.

---

## 1️⃣ Working with HTML Elements

### 1.1 📝 Filling Out a Registration Form

The steps involve completing a form to create a new user account:

- Navigate to the web application: `http://practice.bpbonline.com/`. 🌐
- Click **My Account** → **Continue**.
- Fill in all mandatory fields:
  - Select gender (radio button) 👤
  - First name and last name
  - Date of birth 📅
  - Unique email address (generated for each case) ✉️
  - Company, street address, city, state, postcode
  - Select country from dropdown 🌍 (using `SelectElement`)
  - Telephone number 📞
  - Newsletter checkbox 📰
  - Password and confirmation 🔑
- Click **Submit**.
- Confirm that the account was created: `"Your Account Has Been Created!"` ✅
- Log off and click **Continue**.
- Print a success message in the console with the email used.

---

### 1.2 📊 Working with Web Tables

Goal: Extract product information from the homepage.

- Locate the product table using XPath.
- Traverse table rows and columns (`<tr>` and `<td>`).
- Extract product names and prices.
- Save the extracted information to a CSV file (`productinformation.csv`) in the format:

```
Product Name, Price
```

- Verify that the CSV file:
- Exists
- Is not empty
- File location: `bin/Debug/net{version}/`

---

### 1.3 🔽 Working with Dropdown Elements

Steps for interacting with `<select>` elements and fetching product information per manufacturer:

1. Navigate to the web application.
2. Locate the manufacturer dropdown (`manufacturers_id`) using `SelectElement`.
3. Extract all options and remove `"Please Select"`.
4. Iterate through manufacturers:
 - If no products exist → write a message in `manufacturer.txt`
 - If products exist → traverse the product table and write the details to `manufacturer.txt`
5. Close the browser.

**Additional details:** `ReadOnlyCollection<IWebElement>` and XPath are used to locate elements efficiently.

---

## 2️⃣ Data-Driven Operations – Number Calculator

Goal: Perform calculations using a local HTML calculator with different input sets.

**Application structure:**

- Fields: `First Number`, `Second Number`
- Dropdown: `Operation` (+, -, *, /)
- Buttons: `Calculate` and `Reset`
- Result field

**Steps:**

1. Navigate to the local HTML file `number-calculator.html`.
2. Initialize elements (first number, second number, dropdown, buttons, result field).
3. Method to perform a calculation:
 - Reset all fields
 - Enter numbers and select the operation
 - Click **Calculate**
 - Compare the result with the expected output
4. Data-driven approach with `[TestCase]`:
 - Various combinations of numbers and operations
 - Handles special cases like division by zero, invalid input, and exponential numbers

**Example combinations:**

| First Number | Operation | Second Number | Expected Result |
|--------------|-----------|---------------|----------------|
| 5            | +         | 10            | Result: 15     |
| 3.5          | -         | 1.2           | Result: 2.3    |
| 5            | /         | 0             | Result: Infinity|
| invalid      | +         | 10            | Result: invalid input |

**Advantages of this approach:**

- Reuses logic for multiple input sets
- Easy to add new test cases
- Maintains consistent execution for all scenarios

---

## ✅ Conclusion

The solutions demonstrate handling various web elements:

- Forms and radio buttons  
- Web tables and CSV files  
- Dropdown menus and text files  
- Local HTML applications with multiple data sets  

**Technologies:**

- C# and .NET Core  
- Selenium WebDriver + ChromeDriver  
- NUnit framework  
- CSV and text files for storing output  

💡 **Tip:** Running in **headless mode** can improve execution speed.

