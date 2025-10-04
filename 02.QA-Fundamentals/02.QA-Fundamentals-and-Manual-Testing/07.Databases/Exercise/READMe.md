# Task Board System - Databases Homework

## Project Description
This homework is related to the **Task Board System**. You are required to interact with the database using SQL queries to create, update, and retrieve tasks. The goal is to practice working with relational databases and writing SQL statements.


---

## 1. Create Task

**Task:** Using the UI of the Task Board App, create a new task. Then, find the ID of the newly created task using SQL in Workbench.

**Query:**
```sql
SELECT id 
FROM tasks 
WHERE Title = 'NEW TASK23';
```
**Description:**
This query searches for the task by its title and returns the ID assigned by the database.

---

## 2. Edit Task

**Task:** Update the title and description of the task you created using SQL in Workbench.

**Query:**
```sql
UPDATE tasks
SET Title = 'NEW TASK23 Update', 
    description = 'Task is updated'
WHERE id = (SELECT id FROM tasks WHERE Title = 'NEW TASK23');
```
**Description:**
This query finds the task by its previous title and updates both the title and description.

---

## 3. Select All Tasks Created by You

**Task:** Find your user ID and retrieve all tasks you have created.

**Queries:**
```sql
-- Find your user ID
SELECT Id 
FROM aspnetusers 
WHERE UserName = 'JuniorQA';

-- Retrieve all tasks created by your user
SELECT * 
FROM tasks 
WHERE OwnerID = 'e973279e-7209-496e-9b22-169993e00';
```
**Description:**
The first query retrieves your unique user ID from the aspnetusers table.
The second query selects all tasks where the OwnerID matches your user ID, listing all tasks you have created.
