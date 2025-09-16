# Task Board – Homework: Test Management and Issue Tracking

This file contains my solution for the Task Board testing homework.

## Overview
- Created user stories based on the SRS specification.
- Documented bugs and deviations from expected behavior.
- Tested Task Board v.01 and re-tested v.02 after developer fixes.

---

# User Stories – Task Board

### Home Page
- As a user, I want to view the total number of tasks available in the system on the Home Page, so I can have an overview of the task count.
- As a user, I want to see a greeting message on the Home Page.

### Navigation
- I want options for Home, Task Board, Create, and Search on all pages, no matter where I navigate.

### Task Summary
- I want to see the total number of tasks available.
- I want a summary organized by boards, displaying the board name and task count.

### Quick Access Buttons
- I want quick access buttons for Task Board, Create Task, Search Tasks, and RESTful API.

### Task Board Page
- I want boards ordered as Open, In Progress, Done.
- Each task should include title, brief description, and options for 'View' and 'Edit'.

### Task Creation
- I want to create tasks with title, description, and board selection.
- Title is mandatory and must be validated.

### Task Viewing
- I want to view full task details by clicking 'View'.

### Editing
- I want to edit task title, description, or move it to another board, and save changes.

### Searching
- I want to search for tasks by keyword and see relevant results with total count.

---

# Bugs Report – Task Board

| Functionality         | Expected Result | Actual Result |
|----------------------|----------------|---------------|
| Home Page             | Greeting message should display "Welcome" | Greeting message displays "Hello" |
| Content               | Side menu should have Home, Task Board, Create, Search | Only Home and Create are available |
| Tasks                 | Summary of tasks by status | Only total number of tasks is displayed |
| Task Board            | Boards ordered Open, In Progress, Done | Boards ordered Done, In Progress, Open |
| Search Tasks Menu     | Side menu includes Search Tasks | Option missing |
| Total tasks found     | Counter shows matching tasks | Displays 'Sorry, I can't count' |
| Accessing Web API     | Web API accessible via Quick Access button | Button missing, nothing happens |
| Create Button         | Opens task creation form | Button not working |
| Task Board Change     | Status changes update board | Task remains in original board |

