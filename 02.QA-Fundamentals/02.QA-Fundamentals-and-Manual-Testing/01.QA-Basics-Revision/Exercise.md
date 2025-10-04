# QA Basics: Test Scenarios and Cases

## Introduction

Quality Assurance (QA) ensures that applications work as intended and meet user expectations. This document contains example test scenarios and test cases based on a sample software system, demonstrating basic QA principles.

---

## Test Scenario 1: User Login

### Test Cases

| Test Case                    | Steps                                         | Input               | Expected Result                    | Actual Result | Status |
| ---------------------------- | --------------------------------------------- | ------------------- | ---------------------------------- | ------------- | ------ |
| Login with valid credentials | Enter username & password → Click Login       | `user1 / pass123`   | User is logged in                  | -             | -      |
| Login with invalid password  | Enter username & wrong password → Click Login | `user1 / wrongpass` | Error message: Invalid credentials | -             | -      |
| Login with empty fields      | Leave username & password empty → Click Login | -                   | Error message: Fields required     | -             | -      |
| Login SQL injection attempt  | Enter `' OR 1=1 --` → Click Login             | `' OR 1=1 --`       | Error message / login blocked      | -             | -      |

---

## Test Scenario 2: User Registration

### Test Cases

| Test Case                       | Steps                                        | Input                                  | Expected Result                        | Actual Result | Status |
| ------------------------------- | -------------------------------------------- | -------------------------------------- | -------------------------------------- | ------------- | ------ |
| Register with valid data        | Fill in all required fields → Click Register | `user2 / pass123 / email@example.com`  | User account created successfully      | -             | -      |
| Register with existing username | Fill in existing username → Click Register   | `user1 / pass123 / email2@example.com` | Error message: Username already exists | -             | -      |
| Register with invalid email     | Enter invalid email format → Click Register  | `user3 / pass123 / email.com`          | Error message: Invalid email format    | -             | -      |
| Register with empty fields      | Leave all fields empty → Click Register      | -                                      | Error message: Fields required         | -             | -      |

---

## Test Scenario 3: Fund Transfer (Online Banking Example)

### Test Cases

| Test Case                     | Steps                                              | Input           | Expected Result                   | Actual Result | Status |
| ----------------------------- | -------------------------------------------------- | --------------- | --------------------------------- | ------------- | ------ |
| Transfer with valid data      | Enter amount & recipient → Click Transfer          | `100 / userB`   | Transfer successful               | -             | -      |
| Transfer exceeding balance    | Enter amount greater than balance → Click Transfer | `10000 / userB` | Error message: Insufficient funds | -             | -      |
| Transfer with invalid account | Enter non-existent account → Click Transfer        | `100 / userX`   | Error message: Account not found  | -             | -      |
| Transfer with empty fields    | Leave all fields empty → Click Transfer            | -               | Error message: Fields required    | -             | -      |

---


