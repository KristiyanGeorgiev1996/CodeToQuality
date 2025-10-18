# 🧾 Playwright Automation: To-Do List Application

## 📌 Overview

This project represents a **To-Do List web application**, created to demonstrate **automated user interface testing** using **Playwright**.  
It includes the core features typical for such applications — adding, deleting, marking tasks as completed, and filtering them based on their status.

The application allows users to:

- Add new tasks.  
- Mark tasks as completed.  
- Delete existing tasks.  
- Filter tasks through a dropdown menu by criteria: **All**, **Active**, and **Completed**.

---

## 🧩 Project Structure

- **index.html** – contains the main structure of the user interface.  
- **style.css** – defines the visual layout and element styling.  
- **script.js** – manages the logic for creating, deleting, marking, and filtering tasks.  
- **tests/todo.spec.js** – includes Playwright tests that validate the application's behavior.  

---

## ⚙️ Test Requirements

The tests verify that the application responds correctly to core user interactions:

### 1. Add Task
Checks whether entering text and clicking the **Add Task** button adds the new task to the list.

### 2. Delete Task
Checks whether the **Delete** button successfully removes the task from the list.

### 3. Mark as Completed
Checks whether clicking the **Complete** button visually changes the task by adding the CSS class `completed`.

### 4. Filter Tasks
Checks whether selecting a filter (**All**, **Active**, **Completed**) displays only the corresponding tasks.

---

## 🧪 Example Test

Example test that verifies adding a task:

```js
test('user can add a task', async ({ page }) => {
  await page.goto('http://localhost:8081/');
  await page.fill('#task-input', 'Test Task');
  await page.click('#add-task');
  const taskText = await page.textContent('.task');
  expect(taskText).toContain('Test Task');
});
```

---

## ✅ Project Goals

- Apply basic principles of automated testing with Playwright.
- Work with DOM elements by simulating user interactions.
- Develop skills for writing tests that validate real user behavior.
- Strengthen knowledge of JavaScript, HTML, and CSS in the context of UI testing.

## 💡 Possible Extensions

- Add functionality to **edit existing tasks**.
- Save tasks in **localStorage** for data persistence.
- Expand tests to include checks for state saving and visual updates.
