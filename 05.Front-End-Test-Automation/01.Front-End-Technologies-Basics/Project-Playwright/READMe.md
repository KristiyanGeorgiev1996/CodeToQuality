# 🧾 Playwright Automation: GamesPlay Web Application

## 📌 General Information

This project focuses on **automated testing of the user interface** for an existing **GamesPlay web application**.

The HTML, CSS, and JavaScript files were provided as part of the exercise and are **not included in GitHub** to avoid copyright issues.
Only the **test scripts**, created by me with Playwright, are included, validating the core functionality and user flows.

The application allows users to register, log in, browse games, create new games, and navigate to detailed pages for each game.

---

## ⚙️ Test Requirements

The tests validate the following behaviors and functionalities:

1. **Register with valid data**

   * Successfully create a new user with a unique email.
   * Check for redirection and visibility of the "Logout" button.

2. **Register with empty fields**

   * Ensure that registration with empty fields is not allowed and the user remains on the registration page.

3. **Login with valid credentials**

   * Successful login and redirection to the homepage.
   * Check that the "Logout" button is visible.

4. **Login with empty fields**

   * Attempt to log in without data should remain on the login page.

5. **Logout**

   * Successful logout and verification of the "Login" button visibility.

6. **Navigation Bar for Logged-In User**

   * Verify visibility of links and buttons for a logged-in user.
   * Ensure guest buttons are not visible.

7. **Navigation Bar for Guest User**

   * Verify visibility of links and buttons for users who are not logged in.

8. **Create a Game with Empty Fields**

   * Validate that creating a game without filling required fields fails and remains on the create page.

9. **Create a Game with Valid Input**

   * Create a new game with all required fields properly filled.
   * Verify it appears on the homepage.

10. **Home Page for Guest User**

    * Check that main headings are visible and at least 3 games appear on the homepage.

---

## 🧪 Sample Test

Example test for login with valid credentials:

```js
test('Login: valid credentials', async ({ page }) => {
    await page.goto('http://localhost:3000');
    await page.click('text=Login');
    await page.fill('input[name="email"]', 'peter@abv.bg');
    await page.fill('input[name="password"]', '123456');
    await Promise.all([
        page.waitForNavigation(),
        page.click('input[type="submit"]')
    ]);
    await expect(page).toHaveURL('http://localhost:3000');
    await expect(page.locator('text=Logout')).toBeVisible();
});
```

---

## ✅ Project Goals

* Apply the principles of automated testing with Playwright.
* Validate visibility and functionality of navigation and action buttons.
* Test user flows for registration, authentication, and logout.
* Test CRUD operations (game creation) with valid and empty inputs.
* Verify dynamic content on the home page.
* Strengthen JavaScript and DOM manipulation skills through automated tests.

---

## 💡 Possible Extensions

* Add functionality to edit and delete games.
* Test game detail pages, comments, or ratings.
* Expand tests to include filtering, sorting, and pagination.
* Automate visual checks and responsive design verification.
