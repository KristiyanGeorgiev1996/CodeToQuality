# Use Case 1: Landing Page

| Test Case ID | Prerequisites | Title / Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|------------------|-------|----------------|------------|---------|
| TC01 | Homepage | Check the "Optimize Your Time Now!" button | 1. Open the homepage. 2. Find the "Optimize Your Time Now!" button. 3. Click the button. 4. Check if you are redirected to the Registration/Login page. | User is redirected to the Registration/Login page. | Pass | |
| TC02 | Homepage | Check the link to the inspirational video | 1. Open the homepage. 2. Find the link to the video "10 Time Management Tips to Boost Your Productivity". 3. Click the link. 4. Check if the video opens in a new tab. | The video opens in a new tab. | Fail | Bug ID: BG-01 |
| TC03 | Homepage | Check title and description | 1. Open the homepage. 2. Read the text below the title "TIMEWISE". 3. Check if the text is correctly written and explains the functionality of TimeWise clearly. | The text must be written correctly and explain the functionality of TimeWise. | Fail | Bug ID: BG-02 |
| TC04 | Homepage | Check copyright text | 1. Open the homepage. 2. Read the copyright text at the bottom of the page. 3. Check if the text "© 2023 Copyright: TimeWise" is correctly displayed and phrased. | The text "© 2023 Copyright: TimeWise" should be visible and correctly phrased. | Pass | |
| TC05 | Homepage | Check the clickability of "TimeWise" at the bottom of the page | 1. Open the homepage. 2. Find the "TimeWise" text at the bottom of the page. 3. Click the "TimeWise" text. 4. Check if you are redirected to the Terms of Service page. | User is redirected to the Terms of Service page. | Fail | Bug ID: BG-03 |
| TC06 | Homepage | Check visibility of the "Optimize Your Time Now!" button | 1. Open the homepage. 2. Check if the "Optimize Your Time Now!" button is visible. 3. Click the button and check if it redirects to the Registration/Login page. | The button is visible and redirects to the Registration/Login page. | Pass | |
| TC07 | Homepage | Check video link | 1. Open the homepage. 2. Find the link to the video. 3. Click the link and wait for the video to load. 4. Check if the video plays correctly. | The video should load and play correctly. | Pass | |
| TC08 | Homepage | Check page scrolling | 1. Open the homepage. 2. Scroll down the page. 3. Check if all elements (button, link, text) are correctly placed and visible. | The page should scroll correctly with all elements remaining visible. | Pass | |

---

# Use Case 2: User Registration

| Test Case ID | Prerequisites | Title / Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|------------------|-------|----------------|------------|---------|
| UR-01 | Landing page | Check if the "Register" button redirects to the registration form | 1. Open the landing page. 2. Click on the "Optimize Your Time Now!" button. | The button should open the registration page. | Pass | |
| UR-02 | Registration page | Check "First Name" field | 1. Open the registration form. 2. Enter a first name with 1 character. 3. Enter a first name with 40 characters. 4. Enter a valid first name with length between 2 and 40 characters. | 1 character - error. 40 characters - valid. 2-40 characters - valid name. | Pass | |
| UR-03 | Registration page | Check "Middle Name" field | 1. Open the registration form. 2. Enter a middle name with 1 character. 3. Enter a middle name with 41 characters. 4. Enter a valid middle name with length between 1 and 40 characters. | 1 character - error. 41 characters - error. 1-40 characters - valid name. | Pass | |
| UR-04 | Registration page | Check "Last Name" field | 1. Open the registration form. 2. Enter a last name with 1 character. 3. Enter a last name with 40 characters. 4. Enter a valid last name with length between 2 and 40 characters. | 1 character - error. 40 characters - valid. 2-40 characters - valid last name. | Pass | |
| UR-05 | Registration page | Check "Username" field | 1. Open the registration form. 2. Enter a username with 2 characters. 3. Enter a username with 55 characters. 4. Enter a username with length between 3 and 55 characters, unique. | 2 characters - error. 55 characters - valid. 3-55 characters - valid username. | Pass | |
| UR-06 | Registration page | Check "Email" field | 1. Open the registration form. 2. Enter an invalid email (test@com). 3. Enter a valid email with 5 characters. 4. Enter a valid email with length between 6 and 120 characters. | Invalid email - error. 5 characters - error. 6-120 characters - valid email. | Pass | |
| UR-07 | Registration page | Check "Password" field | 1. Open the registration form. 2. Enter a password with 5 characters. 3. Enter a password with 31 characters. 4. Enter a password with length between 6 and 30 characters. | 5 characters - error. 31 characters - error. 6-30 characters - valid password. | Pass | |
| UR-08 | Registration page | Check "Repeat Password" field | 1. Open the registration form. 2. Enter different passwords in the "Password" and "Repeat Password" fields. 3. Enter the same password in both fields. | Different passwords - error. Same passwords - valid. | Pass | |
| UR-09 | Registration page | Check the "Agree to Terms" checkbox | 1. Open the registration form. 2. Do not check the "Agree to Terms" checkbox. 3. Try to submit the form. | If the checkbox is not checked - form is not submitted. | Fail | Bug ID: BG-04 |
| UR-10 | Registration page | Check the link to Terms of Service | 1. Open the registration form. 2. Click on the Terms of Service link. 3. Check if you are redirected to the Terms of Service page. | The link should redirect to the correct Terms of Service page. | Fail | Bug ID: BG-05 |
| UR-11 | Registration page | Check form submission with all fields filled correctly | 1. Open the registration form. 2. Fill all fields with valid values. 3. Check the "Agree to Terms" checkbox. 4. Click on the "Register" button. | Successful registration and redirection to the next page. | Pass | |
| UR-12 | Registration page | Check if the button is labeled "Register" | 1. Open the registration form. 2. Check the button text. | The button text should be labeled "Register". | Fail | Bug ID: BG-06 |
| UR-13 | Registration page | Check "First Name" field for special characters | 1. Open the registration form. 2. Enter a first name with special characters (@, #, $, !). 3. Submit the form. | Special characters should be either accepted or rejected based on validation rules. | Pass | |
| UR-14 | Registration page | Check "Middle Name" field for special characters | 1. Open the registration form. 2. Enter a middle name with special characters (@, #, $, !). 3. Submit the form. | Special characters should be either accepted or rejected based on validation rules. | Pass | |
| UR-15 | Registration page | Check "Last Name" field for special characters | 1. Open the registration form. 2. Enter a last name with special characters (@, #, $, !). 3. Submit the form. | Special characters should be either accepted or rejected based on validation rules. | Pass | |
| UR-16 | Registration page | Check "Username" field for special characters | 1. Open the registration form. 2. Enter a username with special characters (@, #, $, !). 3. Submit the form. | Special characters should be either accepted or rejected based on validation rules. | Pass | |
| UR-17 | Registration page | Check "Email" field for special characters | 1. Open the registration form. 2. Enter an email with special characters (user@domain.com, user@domain.co.uk). 3. Submit the form. | Special characters like '@', '.', etc., should be valid in email addresses. | Pass | |
| UR-18 | Registration page | Check "Password" field for special characters | 1. Open the registration form. 2. Enter a password with special characters (!@#$$%^&*). 3. Submit the form. | Special characters should be allowed if length requirements are met. | Pass | |
| UR-19 | Registration page | Check "Repeat Password" field for special characters | 1. Open the registration form. 2. Enter a password with special characters in both fields. 3. Submit the form. | Both passwords should match; special characters should be accepted. | Pass | |
| UR-20 | Registration page | Check the correctness of the field names | 1. Open the registration page. 2. Check if each field has the correct name (First name, Middle name, Last name, Username, Email, Password, Repeat Password). 3. Confirm labels are accurate. | The field names should match the expected list. | Fail | Bug ID: BG-07 |

---

# Use Case 3: User Login

| Test Case ID | Prerequisites | Title / Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|------------------|-------|----------------|------------|---------|
| UL-01 | Login page | Verify correctness of login fields | 1. Go to the login page. 2. Verify that there are fields for Username or Email and Password. 3. Verify that the "Sign In" button is present. 4. Verify that there is a "Remember Me" checkbox and a "Forgot Password" link. | The Username/Email and Password fields should be present, and the "Sign In" button should be active. | Pass | |
| UL-02 | Login page | Verify the functionality of the "Forgot Password" link | 1. Go to the login page. 2. Click on the "Forgot Password" link. 3. Check if the password recovery page is opened. | The password recovery page should open and show a field for entering email. | Fail | Bug ID: BG-08 |
| UL-03 | Login page | Verify the functionality of the "Register" link | 1. Go to the login page. 2. Click on the "Register" link at the bottom of the page. 3. Check if the registration form opens. | The user should be redirected to the registration form. | Fail | Bug ID: BG-09 |
| UL-04 | Login page | Verify the functionality of the "Sign In" button | 1. Go to the login page. 2. Enter valid data in the Username and Password fields. 3. Click on the "Sign In" button. 4. Check if you are redirected to the home page. | The user should be redirected to the home page. | Pass | |
| UL-05 | Login page | Verify the functionality of the "Sign In" button with invalid data | 1. Go to the login page. 2. Enter invalid data in the Username and Password fields. 3. Click on the "Sign In" button. 4. Check if an error message appears. | The user should receive an error message for invalid data. | Pass | |
| UL-06 | Login page | Verify the functionality of the "Remember Me" checkbox | 1. Go to the login page. 2. Enter valid data in the Username and Password fields. 3. Select the "Remember Me" checkbox. 4. Click on the "Sign In" button. 5. Log out and check if the data is saved. | The Username and Password fields should be automatically filled in on the next login. | Fail | Bug ID: BG-10 |
| UL-07 | Login page | Verify duplicate email or username error | Check if a message appears stating that the email or username is already in use. | The user should receive a message that the email or username is already in use. | Pass | |
| UL-08 | Login page | Verify correctness of text labels and field names | Check if the text labels for "Username" and "Password" fields are correct. | The text labels should be correct and match the requirements. | Fail | Bug ID: BG-11 |
| UL-09 | Login page | Verify switching from login form to registration form | Check if the registration form opens. | The user should be redirected to the registration form. | Pass | |
| UL-10 | Login page | Verify password recovery functionality | Check if an email is received for password recovery. | The user should receive an email for password recovery. | Fail | UL-02 |

 ---

 # Use Case 4: Home Page and Navigation

| Test Case ID | Prerequisites | Title / Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|-------------------|-------|----------------|------------|---------|
| Nav-01 | Home Page and Navigation | Check the presence of the Navbar | 1. Log in to the application. 2. Check if the Navbar is visible with a link to the Home Page and the profile icon. | The Navbar is visible and contains a link to the Home Page and a profile icon. | Pass | |
| Nav-02 | Home Page and Navigation | Check the functionality of the profile icon | 1. Log in to the application. 2. Click on the profile icon. 3. Check if a dropdown menu appears with options "My Profile" and "Edit". | The dropdown menu with options "My Profile" and "Edit" appears. | Pass | |
| Nav-03 | Home Page and Navigation | Check the functionality of the Sidebar Menu | 1. Log in to the application. 2. Check if the Sidebar Menu is visible and contains the options: "To-Do", "In Progress", "Done", "Logout". | The Sidebar Menu contains all the listed options and is displayed correctly. | Pass | |
| Nav-04 | Home Page and Navigation | Check navigation through the Sidebar Menu | 1. Log in to the application. 2. Click on each option in the Sidebar Menu ("To-Do", "In Progress", "Done") and check if it redirects to the respective sections. | Navigation works correctly, and you are redirected to the respective sections (To-Do, In Progress, Done). | Pass | |
| Nav-05 | Home Page and Navigation | Check the functionality of the Logout button | 1. Log in to the application. 2. Click on the "Logout" button in the Sidebar Menu. 3. Confirm that you are logged out of the application. | The user is successfully logged out and redirected to the login page. | Pass | |
| Nav-06 | Home Page and Navigation | Check the visibility of sections on the Home Page | 1. Log in to the application. 2. Check if the sections "Task Creation & To-Do List", "Tasks in Progress", and "Done Tasks" are visible on the Home Page. | The sections "Task Creation & To-Do List", "Tasks in Progress", and "Done Tasks" are visible. | Pass | |
| Nav-07 | Home Page and Navigation | Check the content of the sections on the Home Page | 1. Log in to the application. 2. Check the content of each section on the Home Page (motivational phrase, short description, image). | Each section contains a motivational phrase, a short description, and an image. | Pass | |
| Nav-08 | Home Page and Navigation | Check the functionality of the link to the TimeWise Home Page | 1. Log in to the application. 2. Click on the link to the TimeWise Home Page in the Navbar. 3. Confirm that you are redirected to the Home Page. | The link to the TimeWise Home Page redirects correctly to the Home Page. | Pass | |
| Nav-09 | Home Page and Navigation | Check the Navbar navigation for other pages | 1. Log in to the application. 2. Click on the profile icon and check if you can navigate to "My Profile" and "Edit". | Navigation in the dropdown menu works correctly, redirecting you to the respective page. | Pass | |
| Nav-10 | Home Page and Navigation | Check the state of the "In Progress" section | 1. Log in to the application. 2. Check if the "In Progress" section is empty or contains tasks, depending on the current task status. | The "In Progress" section contains the relevant tasks or is empty. | Pass | |

---

# Use Case 5: Profile Management

| Test Case ID | Prerequisites | Title / Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|-------------------|-------|----------------|------------|---------|
| PM-01 | Profile Management | Check "Edit profile info" button | 1. Log in to the system. 2. Go to "My Profile" via the profile dropdown menu. 3. Click the "Edit profile info" button. | The user should be redirected to the profile editing page, where they can make changes. | Fail | Bug ID: BG-12 |
| PM-02 | Profile Management | Check dropdown menu when clicking the profile icon | 1. Log in to the system. 2. Click the profile icon. | The dropdown menu should appear and contain options like "My Profile" and "Edit". | Pass | |
| PM-03 | Profile Management | Check the ability to edit first name | 1. Log in to the system.  2. Click "Edit" in the profile dropdown menu. 3. Change the first name in the "First Name" field. 4. Save the changes. | The first name should be successfully updated in the profile. | Fail | Bug ID: BG-13 |
| PM-04 | Profile Management | Check the ability to edit profile picture via URL | 1. Log in to the system. 2. Click "Edit" in the profile dropdown menu. 3. Add a valid URL for the profile picture. 4. Save the changes. | The profile picture should be updated with the new URL. | Fail | Bug ID: BG-14 |
| PM-05 | Profile Management | Check the ability to edit last name | 1. Log in to the system. 2. Click "Edit" in the profile dropdown menu. 3. Change the last name in the "Last Name" field. 4. Save the changes. | The last name should be successfully updated in the profile. | Fail | Bug ID: BG-15 |

---

# Use Case 6: Task Creation and Management

| Test Case ID | Prerequisites | Description | Steps | Expected Result | Pass / Fail | Comments |
|--------------|---------------|------------|-------|----------------|------------|---------|
| TCM-01 | Task Creation | Verify Task Name field accepts valid input | 1. Click "Create Task" button. 2. Enter Task Name with 5 to 30 characters. | Task name is accepted. | Pass | |
| TCM-02 | Task Creation | Verify Task Name field rejects input less than 5 characters | 1. Click "Create Task" button. 2. Enter Task Name with less than 5 characters. | Error message displayed: "Task Name must be at least 5 characters." | Pass | |
| TCM-03 | Task Creation | Verify Task Name field rejects input more than 30 characters | 1. Click "Create Task" button. 2. Enter Task Name with more than 30 characters. | Error message displayed: "Task Name must be no more than 30 characters." | Pass | |
| TCM-04 | Task Creation | Verify Description field accepts valid input | 1. Click "Create Task" button. 2. Enter Description with 30 to 256 characters. | Description is accepted. | Pass | |
| TCM-05 | Task Creation | Verify Description field rejects input less than 30 characters | 1. Click "Create Task" button. 2. Enter Description with less than 30 characters. | Error message displayed: "Description must be at least 30 characters." | Pass | |
| TCM-06 | Task Creation | Verify Description field rejects input more than 256 characters | 1. Click "Create Task" button. 2. Enter Description with more than 256 characters. | Error message displayed: "Description must be no more than 256 characters." | Pass | |
| TCM-07 | Task Creation | Verify Start Date field accepts valid date | 1. Click "Create Task" button. 2. Select a valid Start Date. | Start Date is accepted. | Pass | |
| TCM-08 | Task Creation | Verify Start Date field rejects invalid date | 1. Click "Create Task" button. 2. Select an invalid Start Date. | Error message displayed: "Please enter a valid date." | Pass | |
| TCM-09 | Task Creation | Verify End Date field accepts valid date after Start Date | 1. Click "Create Task" button. 2. Select a valid End Date that is after the Start Date. | End Date is accepted. | Pass | |
| TCM-10 | Task Creation | Verify End Date field rejects date before Start Date | 1. Click "Create Task" button. 2. Select an End Date that is before the Start Date. | Error message displayed: "End Date must be after Start Date." | Pass | |
| TCM-11 | Task Creation | Verify Status field is required and accepts valid input | 1. Click "Create Task" button. 2. Select a valid Status from the dropdown. | Status is selected correctly. | Pass | |
| TCM-12 | Task Creation | Verify "CREATE" button functionality | 1. Click "Create Task" button. 2. Fill all the required fields with valid input. 3. Click "CREATE" button. | Task is created successfully | Pass | |
| TCM-13 | Task Creation | Verify "CANCEL" button functionality | 1. Click "Create Task" button. 2. Click "CANCEL" button without entering any data. | The form is closed and no data is saved. | Pass | |
| TCM-14 | Task Creation | Verify error message for missing required fields | 1. Click "Create Task" button. 2. Leave one or more fields empty. 3. Click "CREATE" button. | Error message displayed: "All fields are required." | Fail | |

---

# Bug Report

| Bug ID | Test Case ID | Priority | Severity | Title | Steps to Reproduce | Expected Result | Actual Result | Comments |
|--------|--------------|----------|---------|-------|------------------|----------------|---------------|---------|
| BG-01 | TC02 | Low | Low | Opening video to the website in a new tab | 1. Open the homepage. 2. Find the link to the video "10 Time Management Tips to Boost Your Productivity". 3. Click the link. 4. Check if the video opens in a new tab. | The video opens in a new tab. | The video does not open in a new tab, but instead opens in the same tab. | |
| BG-02 | TC03 | High | Low | Title and Description | 1. Open the homepage. 2. Read the text below the title "TIMEWISE". 3. Check if the text is correctly written and explains the functionality of TimeWise clearly. | The text must be written correctly and explain the functionality of TimeWise. | The text "Optimize your time now!" is written as "Organize your time now!" | |
| BG-03 | TC05 | Medium | Blocking | Terms of Use and Copyrights | 1. Open the homepage. 2. Find the "TimeWise" text at the bottom of the page. 3. Click the "TimeWise" text. 4. Check if you are redirected to the Terms of Service page. | User is redirected to the Terms of Service page. | When clicking the text that should show the copyright information, it does not display it, but redirects us back to the homepage. | |
| BG-04 | UR-09 | High | Critical | Check the "Agree to Terms" checkbox | 1. Open the registration form. 2. Do not check the "Agree to Terms" checkbox. 3. Try to submit the form. | If the checkbox is not checked - form is not submitted. | The form is accepted even without checking the acceptance of the terms. | |
| BG-05 | UR-10 | High | Blocking | Check the link to Terms of Service | 1. Open the registration form. 2. Click on the Terms of Service link. 3. Check if you are redirected to the Terms of Service page. | The link should redirect to the correct Terms of Service page. | The button cannot be clicked, and the terms and conditions cannot be viewed. | |
| BG-06 | UR-12 | Medium | Medium | Check if the button is labeled "Register" | 1. Open the registration form. 2. Check the button text. | The button text should be labeled "Register". | The button is labeled "Sign in," which could confuse the application user. | |
| BG-07 | UR-20 | High | Blocking | Check the correctness of the field names | 1. Open the registration page. 2. Check if each field has the correct name (First name, Middle name, Last name, Username, Email, Password, Repeat Password). 3. Confirm that the label text is accurate and clear. | The field names should match the following: First name, Middle name, Last name, Username, Email, Password, Repeat Password. | Instead of "Last Name," "Middle Name" is written twice. | |
| BG-08 | UL-02 | High | Blocking | Verify the functionality of the "Forgot Password" link | 1. Go to the login page. 2. Click on the "Forgot Password" link. 3. Check if the password recovery page is opened. | The password recovery page should open and show a field for entering email. | The button doesn't work. | |
| BG-09 | UL-03 | High | Critical | Verify the functionality of the "Register" link | 1. Go to the login page. 2. Click on the "Register" link at the bottom of the page. 3. Check if the registration form opens. | The user should be redirected to the registration form. | The link doesn't work. | |
| BG-10 | UL-06 | Medium | High | Verify automatically | Log out and check if the data is saved. | The Username and Password fields should be automatically filled in on the next login. | The username is saved, but the password isn't. | |
| BG-11 | UL-08 | High | Critical | Verify correctness of text labels and field names | Check if the text labels for "Username" and "Password" fields are correct. | The text labels should be correct and match the requirements. | Upon login, it says "email or username," but in reality, it only works with the email. | |
| BG-12 | PM-01 | High | Critical | Check "Edit profile info" button | 1. Log in to the system. 2. Go to "My Profile" via the profile dropdown menu. 3. Click the "Edit profile info" button. | The user should be redirected to the profile editing page, where they can make changes. | The button does not work. | |
| BG-13 | PM-03 | High | Critical | Check the ability to edit first name | 1. Log in to the system.  2. Click "Edit" in the profile dropdown menu. 3. Change the first name in the "First Name" field. 4. Save the changes. | The first name should be successfully updated in the profile. | The data is not updated. | |
| BG-14 | PM-04 | High | Critical | Check the ability to edit profile picture via URL | 1. Log in to the system. 2. Click "Edit" in the profile dropdown menu. 3. Add a valid URL for the profile picture. 4. Save the changes. | The profile picture should be updated with the new URL. | The data is not updated. | |
| BG-15 | PM-05 | High | Critical | Check the ability to edit last name | 1. Log in to the system. 2. Click "Edit" in the profile dropdown menu. 3. Change the last name in the "Last Name" field. 4. Save the changes. | The last name should be successfully updated in the profile. | The data is not updated. | |

---
