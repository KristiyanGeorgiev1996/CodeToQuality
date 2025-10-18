# 🧾 Playwright Automation: Online Book Library

## 📌 Overview

This project focuses on **automated UI testing** of an existing **online book library web application**.
The HTML, CSS, and JavaScript files were provided as part of the exercise. The goal of the project is to create **Playwright tests** that verify the main functionality and user interactions with the application.

The application allows users to view books, register and log in, add new books, and navigate to detailed pages for each book.

---

## ⚙️ Test Requirements

The tests validate key interactions and user flows. Each test is described in detail:

1. **Verify visibility of "All Books" link for guests**

   * Ensures that the catalog link is visible to users who are not logged in.

2. **Verify visibility of "Login" button**

   * Checks that the login button is visible for guests.

3. **Verify visibility of "Register" button**

   * Checks that the registration button is visible for guests.

4. **Verify visibility of "All Books" link after login**

   * Ensures that the catalog link remains visible for logged-in users.

5. **Login with valid credentials**

   * Tests successful login with a correct email and password and redirection to the catalog.

6. **Login with empty fields**

   * Attempting to log in without filled fields should trigger an alert with the correct message and keep the user on the login page.

7. **Add a book with valid data**

   * Tests adding a book with all required fields correctly filled and checks its appearance in the catalog.

8. **Add a book with an empty title**

   * Attempting to add a book with a missing required field (title) triggers an alert and prevents the addition.

9. **Verify all books are displayed after login**

   * Tests that all available books are displayed correctly in the list after logging in.

10. **Navigate to the book details page**

    * Checks that clicking the details button opens the page with the correct information for the selected book.

---

## 🧪 Sample Test

A sample test that verifies login with valid credentials:

```js
test('Login with valid credentials', async ({ page }) => {
    await page.goto('http://localhost:3000/login')
    await page.fill('#email', 'peter@abv.bg')
    await page.fill('#password', '123456')
    await page.click('input[value="Login"]')
    
    const pageURL = page.url()
    expect(pageURL).toBe('http://localhost:3000/catalog')
})
```

---

## ✅ Project Goals

* Apply principles of automated testing using Playwright.
* Validate the visibility and functionality of navigation and action buttons.
* Test user flows for authentication and form validation.
* Test dynamic content in the catalog and book details pages.
* Strengthen skills in JavaScript, HTML, CSS, and DOM manipulation through automated tests.

## 💡 Possible Extensions

* Add functionality for editing and deleting books.
* Manage user profiles with added books.
* Extend tests to verify pagination, filtering, or sorting in the catalog.
* Add data pers
