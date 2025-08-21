# Homework: Types and Levels of Testing (Rewritten & Enhanced)

## 1. Unit Testing in Real Life: Smart Thermostat

**Scenario / Condition:** Test a smart thermostat that controls home temperature and humidity. Ensure accurate readings and proper responses to user input.

| Test # | Description | Expected Result | Pass/Fail |
|--------|-------------|----------------|-----------|
| 1 | Set target temperature to 22°C | Thermostat adjusts heating/cooling correctly | Pass |
| 2 | Read current temperature | Sensor reports ±1°C accuracy | Pass |
| 3 | Set humidity to 50% | Humidifier/dehumidifier responds | Pass |
| 4 | Power cycle | Device retains settings | Pass |
| 5 | Connect to app | App shows correct temperature/humidity | Pass |

---

## 2. Unit Testing in Real Life: Electric Toothbrush

**Scenario / Condition:** Test an electric toothbrush with multiple speed settings and timer function.

| Test # | Description | Expected Result | Pass/Fail |
|--------|-------------|----------------|-----------|
| 1 | Turn on low speed | Motor runs at low speed | Pass |
| 2 | Turn on high speed | Motor runs at high speed | Pass |
| 3 | Timer 2 min | Auto-stop after 2 minutes | Pass |
| 4 | Battery level 20% | Warning indicator lights | Pass |
| 5 | Charging | Full charge shows 100% | Pass |

---

## 3. Unit Testing in Software: Age Group Function

**Scenario / Condition:** Verify AgeClassifier categorizes people into "kid", "teen", "adult", "senior" correctly.

| Test # | Input | Expected Output | Pass/Fail |
|--------|-------|----------------|-----------|
| 1 | 6 | kid | Pass |
| 2 | 12 | kid | Pass |
| 3 | 13 | teen | Pass |
| 4 | 17 | teen | Pass |
| 5 | 25 | adult | Pass |
| 6 | 60 | adult | Pass |
| 7 | 65 | senior | Pass |
| 8 | 90 | senior | Pass |
| 9 | -3 | error | Pass |
| 10 | 151 | error | Pass |

---

## 4. Unit Testing in Software: Discount Calculator

**Scenario / Condition:** Verify function calculates discounts based on user membership levels: "none", "silver", "gold", "platinum".

| Test # | Input | Expected Output | Pass/Fail |
|--------|-------|----------------|-----------|
| 1 | none, 100 | 0% discount | Pass |
| 2 | silver, 200 | 5% discount | Pass |
| 3 | gold, 300 | 10% discount | Pass |
| 4 | platinum, 500 | 20% discount | Pass |
| 5 | invalid level | error | Pass |
| 6 | negative amount | error | Pass |
| 7 | zero amount | 0% discount | Pass |
| 8 | gold, 0 | 0% discount | Pass |
| 9 | silver, 1000 | 5% discount | Pass |
| 10 | platinum, 50 | 20% discount | Pass |

---

## 5. Integration Testing in Real Life: Home Security System

**Scenario / Condition:** Test motion sensors, door locks, and alarm system integration.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Open door | Sensor detects and triggers alarm | Pass |
| 2 | Motion in living room | Motion detected, app notified | Pass |
| 3 | Lock door remotely | Door locks successfully | Pass |
| 4 | Power outage | Backup battery keeps system running | Pass |
| 5 | Disable alarm | Alarm stops, sensors inactive | Pass |
| 6 | Re-enable alarm | Sensors active, app notified | Pass |

---

## 6. Integration Testing in Software: Online Booking Platform

**Scenario / Condition:** Verify login, booking, payment, and confirmation workflow.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | User login valid | Dashboard opens | Pass |
| 2 | User login invalid | Error message displayed | Pass |
| 3 | Book available slot | Booking confirmed | Pass |
| 4 | Book unavailable slot | Error message displayed | Pass |
| 5 | Payment success | Confirmation email sent | Pass |
| 6 | Payment failed | Booking cancelled | Pass |
| 7 | Cancel booking | Booking removed | Pass |
| 8 | Session timeout | User redirected to login | Pass |

---

## 7. Integration Testing in Software: Loan Approval Calculator

**Scenario / Condition:** Verify calculator determines approval based on age, income, and credit score. Include edge cases.

| Test # | Age | Income | Credit Score | Expected Result | Pass/Fail |
|--------|-----|--------|--------------|----------------|-----------|
| 1 | 25 | 2000 | 700 | Approved | Pass |
| 2 | 18 | 800 | 650 | Rejected | Pass |
| 3 | 65 | 3000 | 720 | Approved | Pass |
| 4 | 17 | 500 | 600 | Rejected | Pass |
| 5 | 30 | -100 | 700 | Error | Pass |
| 6 | 40 | 1000 | 300 | Rejected | Pass |
| 7 | 55 | 4000 | 800 | Approved | Pass |
| 8 | 20 | 1500 | 500 | Rejected | Pass |
| 9 | 75 | 2000 | 700 | Approved | Pass |
| 10 | 10 | 100 | 600 | Rejected | Pass |

---

## 8. System Testing in Real Life: Robotic Vacuum

**Scenario / Condition:** Test vacuum in different scenarios: battery, cleaning modes, obstacle detection, app control.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Start cleaning | Vacuum moves and cleans | Pass |
| 2 | Low battery | Returns to dock | Pass |
| 3 | Obstacle detected | Changes path | Pass |
| 4 | Full dustbin | Stops and alerts | Pass |
| 5 | App control | Commands executed correctly | Pass |
| 6 | Edge cleaning | Cleans near walls | Pass |
| 7 | Carpet mode | Adjusts suction | Pass |
| 8 | Schedule cleaning | Starts at scheduled time | Pass |
| 9 | Continuous cleaning 2h | No errors | Pass |
| 10 | Emergency stop | Stops immediately | Pass |

---

## 9. System Testing in Real Life: Smart Door Lock

**Scenario / Condition:** Test mechanical and electronic lock features for security and durability.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Lock manually | Lock engages | Pass |
| 2 | Unlock with code | Lock opens | Pass |
| 3 | Unlock with remote app | Lock opens | Pass |
| 4 | Battery low | Warning indicator | Pass |
| 5 | Forced entry attempt | Alarm triggers | Pass |
| 6 | Power outage | Manual key works | Pass |

---

## 10. System Testing in Software: Number Calculator App

**Scenario / Condition:** Test various operations including edge cases, invalid input, large/small numbers.

| Test # | Description | Expected Result | Pass/Fail |
|--------|-------------|----------------|-----------|
| 1 | Add 5 + 10 | 15 | Pass |
| 2 | Add 2e12 + 5 | 2e12 + 5 | Pass |
| 3 | Add "10x" + "abc" | Error | Pass |
| 4 | Divide 10 / 0 | Error | Pass |
| 5 | Multiply 1e10 * 1e10 | 1e20 | Pass |
| 6 | Subtract -5 - (-10) | 5 | Pass |
| 7 | Square root of -1 | Error | Pass |
| 8 | Large exponent | Correct result or error | Pass |
| 9 | Decimal division | Correct decimal | Pass |
| 10 | Input null | Error | Pass |

---

## 11. Acceptance Testing in Real Life: Flashlight

**Scenario / Condition:** Ensure flashlight meets customer expectations: light, battery, usability.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Turn on | Light illuminates | Pass |
| 2 | Turn off | Light goes off | Pass |
| 3 | Battery replacement | Works after new batteries | Pass |
| 4 | Drop test | Survives minor drops | Pass |
| 5 | Brightness | Matches specifications | Pass |

---

## 12. Acceptance Testing in Real Life: Digital Scale

**Scenario / Condition:** Ensure scale is accurate, durable, and user-friendly.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Measure 70kg | Reads ±0.1kg | Pass |
| 2 | Measure 0kg | Reads 0 | Pass |
| 3 | Low battery | Warning displayed | Pass |
| 4 | Step on quickly | Accurate reading | Pass |
| 5 | Surface tilt | Corrects or warns | Pass |

---

## 13. Acceptance Testing in Software: Number Calculator App

**Scenario / Condition:** Ensure the app satisfies end-user needs and usability.

| Test # | Scenario | Expected Result | Pass/Fail |
|--------|---------|----------------|-----------|
| 1 | Add numbers | Correct sum | Pass |
| 2 | Subtract numbers | Correct difference | Pass |
| 3 | Multiply numbers | Correct product | Pass |
| 4 | Divide numbers | Correct quotient | Pass |
| 5 | Invalid input | Shows clear error | Pass |

---

## 14. Functional vs Non-Functional Testing: Flashlight

| Functional Tests | Non-Functional Tests |
|-----------------|--------------------|
| Turn on/off | Battery life |
| Brightness | Resistance to drops |
| Mode switch | Performance at extreme temperature |
| Replace bulb/battery | Durability over long-term use |
| Warning indicator | Light intensity consistency |

