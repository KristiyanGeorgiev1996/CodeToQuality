# TimeWise QA Project – Task Requirements

## Part I – Web Application Testing

**Objective:**  
Verify that the TimeWise web application behaves according to its functional specifications. This includes creating test cases for each defined use case and identifying any issues.

### Use Cases

#### Use Case 1 – Landing Page
- Users can access the TimeWise application via its URL.  
- The Landing Page must display a **call-to-action button** that redirects to the Login/Register page.  
- A video link should be available for visitors to view in a new tab.  
- Footer links, including Terms of Service, must be visible and functional.

#### Use Case 2 – User Registration
- From the Registration/Login page, visitors should navigate to the registration form.  
- Users must be able to complete all required fields (First Name, Middle Name, Last Name, Username, Email, Password, Repeat Password).  
- Agreeing to the Terms of Service is mandatory.  
- Form validation must enforce character limits and field requirements.

#### Use Case 3 – User Login
- Users should log in with either Username or Email and Password.  
- Options include "Remember Me" and "Forgot Password".  
- The forgot password flow must allow users to recover their password via verified email.

#### Use Case 4 – Home Page & Navigation
- After login, users access the Home Page, featuring a Navbar and a Profile Icon dropdown.  
- Sidebar menu allows navigation between boards: To-Do, In Progress, Done.  
- Users should be able to log out via the Logout button.

#### Use Case 5 – Profile Management
- Users can view and edit their profile information: First Name, Middle Name, Last Name, Avatar (via URL).  
- All changes must be reflected correctly in the profile.

#### Use Case 6 – Task Creation & Management
- Users can create new tasks on the To-Do board using a form with Task Name, Description, Start/End Dates, and Status.  
- Tasks should appear on the correct board and be editable, deletable, or movable between boards (To-Do → In Progress → Done).

---

## Part II – API Testing (Postman)

**Objective:**  
Verify the backend API of TimeWise for correct functionality using Postman.  

### Base URL
http://timewise2-env.eba-mkmm3jwy.eu-north-1.elasticbeanstalk.com/api

### Supported Endpoints

#### User
- `POST /api/User/Register` – register a new user.  
- `POST /api/User/Authorization` – login and receive an access token.

#### Tasks (Authorization required)
- `GET /api/Task/AllTasks` – retrieve all tasks.  
- `GET /api/Task/Count` – retrieve task counts by status.  
- `POST /api/Task/Create` – create a new task.  
- `PUT /api/Task/Edit/{taskId}` – update a task.  
- `DELETE /api/Task/Delete/{taskId}` – remove a task.

### API Testing Workflow
1. Log in via API and obtain an access token.  
2. Create a new task using the API.  
3. Retrieve all tasks and verify the new task exists.  
4. Update the task details via API.  
5. Delete the task via API.  
6. Organize all requests in a Postman collection.

---

