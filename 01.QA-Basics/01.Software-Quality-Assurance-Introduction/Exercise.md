# 🧪 Homework: Software Quality Assurance  

## 1. Think Like a QA: Supermarket Checkout  
**Problem:** At the checkout, the total amount displayed on the screen is different from the amount printed on the receipt.  
**Solution:** QA should test the system by making several purchases, compare the totals on the screen and the printed receipt, and check whether the data matches in the database. If inconsistencies are found, a defect report with reproduction steps must be logged.  

---

## 2. Think Like a QA: Online Movie Reservation  
**Problem:** A user selects specific seats in a cinema hall, but after confirmation, they receive different seats.  
**Solution:** QA should perform tests by simulating reservations for different movies and time slots to verify whether the system correctly saves the selected seats. It should also be tested what happens when two people reserve the same seat at the same time.  

---

## 3. Think Like a QA: Courier Delivery  
**Problem:** A shipment is marked as "delivered" in the app, but the customer never received it.  
**Solution:** QA can test the status update process — whether statuses are correctly saved in the system and whether customer notifications are accurate. It should also be checked how the system handles incorrect or manually entered courier data.  

---

## 4. Login Form: User Interface Issues  
**Problem:** When filling in the login form with valid credentials, the system sometimes does not recognize the user, or the “Login” button does not respond.  
**Solution:** QA should test by entering various combinations of valid and invalid data, check how the system reacts to empty fields, invalid email formats, and overly long passwords. Additionally, the response of the button should be checked across different browsers and devices.  

---

## 5. Weather Forecast Defect  
**Error (in code):** The programmer confused Celsius with Fahrenheit.  
**Defect / Bug:** In the temperature conversion module, the correct conversion formula is missing.  
**Failure (symptoms):** The app displays 75°C instead of 24°C for a given city.  
**Solution:** QA should test the model with different values and compare the results with actual meteorological data. After fixing the issue, regression tests should be performed to ensure the bug has not reappeared elsewhere.  

---

## 6. Age Verification Machine  
**Problem:** A ticket machine at an amusement park incorrectly allows children under 12 years old to access rides intended for adults.  
**Solution:** QA should test boundary values — e.g., ages 11, 12, and 13 — to confirm whether the system applies the rules correctly. Invalid data inputs (such as negative ages or text instead of numbers) should also be tested.  

---

## 7. Testing a Vending Machine  
**Problem:** The vending machine accepts money but sometimes fails to return change or dispenses the wrong drink.  

### 🔹 Test Scenario 1: Payment with Exact Amount  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC1.1 | Selecting a drink with the exact price | 1. Select a drink for $2.00<br>2. Insert $2.00<br>3. Press “OK” | The machine should dispense the correct drink with no change |

### 🔹 Test Scenario 2: Payment with a Larger Amount  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC2.1 | Returning change | 1. Select a drink for $1.50<br>2. Insert $2.00<br>3. Confirm selection | The machine should dispense the drink and return $0.50 |

### 🔹 Test Scenario 3: Out-of-Stock Drink  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC3.1 | Attempting to buy an unavailable drink | 1. Select a drink marked “Out of stock”<br>2. Insert money | The machine should display “Out of stock” and return the money |

---

## 8. Testing an ATM  
**Problem:** The ATM sometimes does not return the card after a transaction or displays the wrong account balance.  

### 🔹 Test Scenario 1: Successful Cash Withdrawal  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC1.1 | Withdrawal of available funds | 1. Insert card<br>2. Enter valid PIN<br>3. Select “Withdraw $100” | The ATM should return the card, dispense $100, and display the reduced balance |

### 🔹 Test Scenario 2: Incorrect PIN  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC2.1 | Entering wrong PIN three times | 1. Insert card<br>2. Enter incorrect PIN three times | The ATM should block the card and display “Card blocked” |

### 🔹 Test Scenario 3: Balance Inquiry  
| Test Case | Description | Steps | Expected Result |
|-----------|-------------|-------|----------------|
| TC3.1 | Correct balance displayed | 1. Insert card<br>2. Enter valid PIN<br>3. Select “Check Balance” | The ATM should return the card and display the correct account balance |

---
