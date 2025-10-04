# Mini To-Do App (C#) - Manual Testing README

## Project Description

A console application for managing tasks (To-Do List). The application allows users to:

* Add a new task
* Remove an existing task
* Mark a task as completed
* Display all tasks with a status indication (Pending/Completed)

The project is suitable for **manual testing**, to practice checking functionality without writing automated tests.

---

## Running the Project

1. Open the project in Visual Studio or another C# IDE.
2. Run the `MiniToDoApp` project.
3. Use the console menu to perform operations on tasks.

---

## Manual Testing Plan

### Test Case 1: Add Task

1. Start the application.
2. Select option 1 (Add Task).
3. Enter the title: "Task 1".
4. Select option 4 (Show All Tasks).
5. Verify that "Task 1" is displayed with status Pending.

### Test Case 2: Remove Task

1. Select option 2 (Remove Task).
2. Enter the title: "Task 1".
3. Select option 4 (Show All Tasks).
4. Verify that "Task 1" is no longer in the list.

### Test Case 3: Mark Task Completed

1. Add a task "Task 2".
2. Select option 3 (Mark Task Completed).
3. Enter the title: "Task 2".
4. Select option 4 (Show All Tasks).
5. Verify that "Task 2" has status Completed.

### Test Case 4: Show All Tasks

1. Add multiple tasks.
2. Select option 4 (Show All Tasks).
3. Verify that all tasks are displayed with the correct status.

---

## Manual Testing Objectives

* Ensure that the core functionalities of the application work correctly.
* Practice verifying results through visual inspection.
* Document test scenarios for further QA training.
