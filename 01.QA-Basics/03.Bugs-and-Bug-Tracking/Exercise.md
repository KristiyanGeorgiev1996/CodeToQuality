# Homework: Bugs and Bug Tracking Systems

This homework includes a set of exercises for reporting bugs in different applications and systems. The goal is to practice QA skills in detecting, describing, and classifying defects.

---

## 1. Bug Reporting: Weather App

**Task Description:**  
Test the “Current Temperature” function. QA should report a bug if the app shows an incorrect temperature.  

| Field | Details |
|-------|---------|
| Bug ID | WV-001 |
| Priority | High |
| Severity | Critical |
| Assigned to | Alex Johnson |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | Android 12 / App version 1.0 |
| Summary | The app displays incorrect current temperature |
| Description | When the app is opened, the temperature is 10°C lower than the actual temperature. |
| Expected Behavior | The app should display the correct temperature for the selected city. |
| Actual Behavior | Displays temperature 10°C lower than real. |
| Steps to Reproduce | 1. Open the app.<br>2. Select a city.<br>3. Check the displayed temperature. |

---

## 2. Bug Reporting: To-Do List App

**Task Description:**  
Test the “Add Task” feature. QA should report a bug if new tasks are not saved.  

| Field | Details |
|-------|---------|
| Bug ID | TD-001 |
| Priority | Medium |
| Severity | High |
| Assigned to | Maria Lopez |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | Windows 10 / Chrome |
| Summary | New tasks disappear after closing the app |
| Description | When a new task is added and the app is closed, the task is not saved. |
| Expected Behavior | Tasks should be retained after restart. |
| Actual Behavior | Task disappears after closing and reopening the app. |
| Steps to Reproduce | 1. Open the app.<br>2. Add a new task.<br>3. Close the app.<br>4. Reopen the app.<br>5. Check if the task exists. |

---

## 3. Bug Reporting: Online Calculator

**Task Description:**  
Test the “Division” function. QA should report a bug if division by zero is not handled.  

| Field | Details |
|-------|---------|
| Bug ID | OC-001 |
| Priority | High |
| Severity | Critical |
| Assigned to | Tom Evans |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | iOS 16 / Safari |
| Summary | Calculator crashes on division by zero |
| Description | Dividing a number by zero causes the app to crash instead of showing an error. |
| Expected Behavior | The app should show an error message: “Cannot divide by zero”. |
| Actual Behavior | The app crashes. |
| Steps to Reproduce | 1. Open the calculator.<br>2. Enter a number.<br>3. Press divide "/" and enter 0.<br>4. Press "=".<br>5. Observe the crash. |

---

## 4. Bug Reporting: Music Player

**Task Description:**  
Test the “Play/Pause” buttons. QA should report a bug if the player does not respond.  

| Field | Details |
|-------|---------|
| Bug ID | MP-001 |
| Priority | Medium |
| Severity | High |
| Assigned to | Sarah Kim |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | Android 12 / App version 2.3 |
| Summary | Play/Pause buttons sometimes do not work |
| Description | Sometimes pressing “Play” or “Pause” does not start or stop the music. |
| Expected Behavior | Music should start on Play and stop on Pause. |
| Actual Behavior | Music continues or does not start despite pressing. |
| Steps to Reproduce | 1. Open the player.<br>2. Select a song.<br>3. Press “Play”.<br>4. After 5 seconds, press “Pause”.<br>5. Observe behavior. |

---

## 5. Bug Reporting: Contact Form

**Task Description:**  
Test the “Submit” button. QA should report a bug if invalid emails are accepted.  

| Field | Details |
|-------|---------|
| Bug ID | CF-001 |
| Priority | High |
| Severity | High |
| Assigned to | Liam Brown |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | Windows 11 / Chrome |
| Summary | Form accepts invalid email addresses |
| Description | The form allows sending emails without “@” or domain. |
| Expected Behavior | Only valid emails should be accepted. |
| Actual Behavior | Form is submitted even with an invalid email. |
| Steps to Reproduce | 1. Open the form.<br>2. Enter a name.<br>3. Enter an invalid email like “abc.com”.<br>4. Click “Submit”.<br>5. Check if the form is submitted. |

---

## 6. Bug Reporting: Shopping Cart

**Task Description:**  
Test the “Add to Cart” feature. QA should report a bug if the quantity does not update correctly.  

| Field | Details |
|-------|---------|
| Bug ID | SC-001 |
| Priority | Medium |
| Severity | High |
| Assigned to | Emma White |
| Reported by | QA Team |
| Reported on | 21.08.2025 |
| Status | Open |
| Environment | Windows 10 / Firefox |
| Summary | Product quantity in cart does not update |
| Description | Adding the same product multiple times does not increase the quantity. |
| Expected Behavior | Cart should show the correct quantity for the product. |
| Actual Behavior | Quantity always shows “1” regardless of additions. |
| Steps to Reproduce | 1. Open the online store.<br>2. Add a product.<br>3. Add the same product again.<br>4. Open the cart.<br>5. Check the quantity. |
