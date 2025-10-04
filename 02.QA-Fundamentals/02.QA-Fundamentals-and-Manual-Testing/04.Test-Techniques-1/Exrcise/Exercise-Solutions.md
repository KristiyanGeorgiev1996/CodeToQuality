# QA Testing Exercises - Example Solutions

## 1. Age Classification App

**Equivalence Classes:**  
- Valid: 0–12 (Child), 13–19 (Teenager), 20–64 (Adult), 65–150 (Senior)  
- Invalid: <0, >150  

**Boundary Values:**  
- 0, 12, 13, 19, 20, 64, 65, 150, -1, 151  

**Sample Test Cases:**  
| Input | Expected Output | Notes |
|-------|----------------|-------|
| 12    | Child          | Upper boundary of Child |
| 13    | Teenager       | Lower boundary of Teenager |
| 19    | Teenager       | Upper boundary of Teenager |
| 20    | Adult          | Lower boundary of Adult |
| 65    | Senior         | Lower boundary of Senior |
| -5    | Invalid Age    | Invalid input |
| 160   | Invalid Age    | Invalid input |

---

## 2. Train Ticket Fare

**Partitions:**  
- Valid: Peak (before 9:30, 16:00–19:30), Off-peak (9:30–16:00, after 19:30)  
- Invalid: Negative time, >24:00  

**Boundary Values:**  
- 9:29, 9:30, 16:00, 16:01, 19:30, 19:31  

**Sample Test Cases:**  
| Time   | Expected Ticket Type |
|--------|--------------------|
| 9:29   | Full Fare           |
| 9:30   | Saver Ticket        |
| 16:00  | Full Fare           |
| 16:01  | Saver Ticket        |
| 19:30  | Full Fare           |
| 19:31  | Saver Ticket        |

---

## 3. Yoga Class Booking

| Member | Wants Class | Booking Method |
|--------|------------|----------------|
| Yes    | Yes        | Online         |
| Yes    | No         | N/A            |
| No     | Yes        | Phone Call     |
| No     | No         | N/A            |

---

## 4. Railcard Discounts

| Card Type        | Travel With Child | Discount |
|-----------------|-----------------|----------|
| Over 60          | No              | 34%      |
| Family           | Yes             | 50%      |
| None             | No              | 10%      |

---

## 5. Shopping Basket State Transitions

**States:** Empty → Items Added → Checkout → Payment / Back to Shopping  
**Example invalid transition:** Checkout without items

---

## 6. Vending Machine Control Flow

- Cold drink → dispense immediately  
- Hot drink → milk? → sugar? → dispense  

**Statement Coverage:** Test both hot and cold paths  
**Decision Coverage:** Include choices for milk and sugar  

---

## 7. Pairwise Testing

- Total positive combinations without reduction: 10 * 2 * 2 = 40  
- Pairwise reduction: ~10–12 tests  
- Negative tests: invalid selection in list box, wrong radio button value, unchecked mandatory checkbox  

---

## 8. Online Movie Ticket Booking

- Test cases cover each step: search, select, choose seat, payment, confirmation  
- Include valid and invalid seats, showtimes, and payment errors

---

## 9. Registration Form Testing

**Fields and Sample Tests:**  

| Field            | Test Case                  | Expected Result         |
|-----------------|----------------------------|------------------------|
| Username        | 5 letters                  | Error                  |
| Username        | 6 letters + digits         | OK                     |
| Email           | invalid format             | Error                  |
| Password        | 5 chars                    | Error                  |
| Password        | 6–12 chars with all reqs   | OK                     |
| Confirm Password| Doesn't match               | Error                  |
| Clear Form      | Click Clear                 | All fields empty        |
| Create Account  | Valid info                 | Redirect + logged in    |
