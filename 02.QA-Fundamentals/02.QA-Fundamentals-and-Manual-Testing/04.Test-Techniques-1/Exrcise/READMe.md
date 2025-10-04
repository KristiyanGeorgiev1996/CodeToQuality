# QA Testing Exercises - Reformulated

## 1. Age Classification App

**Scenario:** Create an application that classifies a person's age into categories:

- Below 13 → "Child"  
- 13 to 19 → "Teenager"  
- 20 to 64 → "Adult"  
- 65 and above → "Senior"  
- Negative values or over 150 → "Invalid Age"

**Tasks:**  
- **Equivalence Classes:** Identify valid and invalid input groups.  
- **Boundary Values:** Find the edge cases for each category and write test cases including these boundaries.

---

## 2. Train Ticket Fare

**Scenario:** Train tickets are priced differently depending on travel time:  

- Peak hours: before 9:30 AM or 4:00 PM–7:30 PM → full fare  
- Off-peak hours: 9:30 AM–4:00 PM and after 7:30 PM → saver ticket

**Tasks:**  
- Determine valid and invalid time partitions.  
- Identify boundary times for testing.  
- Create test cases for each partition and boundary.

---

## 3. Yoga Class Booking

**Scenario:** A fitness center offers Yoga classes. Booking rules:

- Members book online  
- Non-members book via phone call

**Tasks:**  
- Create a decision table covering all combinations of membership and booking intent.  
- Specify the expected booking method for each scenario.

---

## 4. Railcard Discounts

**Scenario:** Different railcards offer discounts:

- Over 60s card → 34% discount  
- Family card (with a child under 16) → 50% discount  
- Otherwise → 10% discount

**Tasks:**  
- Produce a decision table showing all possible combinations.  
- Derive test cases from the table.

---

## 5. Shopping Basket State Transitions

**Scenario:** Online shopping basket:

- Start empty  
- Items can be added or removed  
- Checkout shows summary; proceed to payment only if correct, else return to shopping

**Tasks:**  
- Draw a state diagram of all states and transitions  
- Create a state table  
- Give an example of an invalid transition test

---

## 6. Vending Machine Control Flow

**Scenario:** Machine dispenses hot or cold drinks. For hot drinks:

- Ask about milk → add if requested  
- Ask about sugar → add if requested  
- Dispense drink

**Tasks:**  
- Draw a control flow diagram  
- Analyze statement and decision coverage for:  
  1. Cold drink  
  2. Hot drink with milk and sugar  
- Suggest additional tests for 100% coverage

---

## 7. Pairwise Testing

**Scenario:** Software form contains:

- List box (0–9)  
- Radio button (On/Off)  
- Checkbox (Checked/Unchecked)  
- OK button (no input, just proceed)

**Tasks:**  
- Calculate total positive test cases if all combinations are tested  
- Reduce the number using Pairwise testing  
- Suggest at least 3 negative test cases

---

## 8. Online Movie Ticket Booking

**Use Case:** Book a movie ticket

**Steps:**

1. Search for a movie  
2. Select movie and showtime  
3. Choose seat  
4. Proceed to payment  
5. Confirm booking  
6. Receive booking confirmation

**Task:** Derive test cases from this use case.

---

## 9. Registration Form Testing

**Scenario:** Test a registration form with fields:

- Username: ≥6 letters/numbers  
- Email: valid format  
- Password: 6–12 characters, includes uppercase, lowercase, number, special character  
- Confirm password: matches password  
- Clear Form clears all fields  
- Create account redirects and shows "You are now logged in."

**Tasks:**  
- Decide which testing techniques to apply  
- Write test cases for all fields and actions
