# Homework: Postman – Task Board System

## Task Description

This homework focuses on using Postman to interact with the Task Board system. The system provides endpoints to create, edit, and delete tasks. Your goal is to practice sending requests, receiving responses, and understanding how task management works through the API.

The tasks you need to perform include:

1. **Create Task**  
   - Use Postman to create a new task.  
   - Include all required attributes for the task (title, description, and board).  
   - Paste the **JSON response** you receive from the server after creating the task.

2. **Edit Task**  
   - Use Postman to edit the task you just created.  
   - Update the title or any other editable field.  
   - Paste the **JSON response** you receive after editing the task.

3. **Delete Task**  
   - Use Postman to delete the task you have edited.  
   - Paste the **JSON response** confirming the deletion.

> **Note:** Do not paste a screenshot of the response body. Use the actual JSON object returned by the API.

---

## My Solutions

### 1. Create Task

```json
[
    {
        "id": 1,
        "title": "Project skeleton",
        "description": "Create project folders, services, controllers and views",
        "board": {
            "id": 1003,
            "name": "Done"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    },
    {
        "id": 2,
        "title": "Home page",
        "description": "Create the [Home] page and list tasks count by board",
        "board": {
            "id": 1003,
            "name": "Done"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    },
    {
        "id": 3,
        "title": "View task board",
        "description": "Create the [Task Board] page and list all tasks by board",
        "board": {
            "id": 1002,
            "name": "In Progress"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    },
    {
        "id": 4,
        "title": "Create tasks",
        "description": "Implement [Create Task] page for adding new tasks",
        "board": {
            "id": 1001,
            "name": "Open"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    },
    {
        "id": 5,
        "title": "Edit tasks",
        "description": "Implement [Edit Tasks] page for editing existing tasks",
        "board": {
            "id": 1001,
            "name": "Open"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    },
    {
        "id": 6,
        "title": "Improve CSS styles",
        "description": "Implement better styling for all public pages",
        "board": {
            "id": 1001,
            "name": "Open"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T15:55:39.909Z"
    }
]
```

---

### 2. Edit Task
```
{
    "msg": "Task edited.",
    "task": {
        "id": 5,
        "title": "Завърши домашните задачи",
        "description": "Implement [Edit Tasks] page for editing existing tasks",
        "board": {
            "id": 1001,
            "name": "Open"
        },
        "dateCreated": "2024-11-24T15:55:39.909Z",
        "dateModified": "2024-11-24T16:11:33.482Z"
    }
}
```

---

### 3. Delete Task
```
{
    "msg": "Task deleted: 5"
}
```

---

**Summary**
This exercise allowed me to:
- Practice using Postman to send GET, POST, PUT, and DELETE requests.
- Understand the structure of the JSON response objects returned by the Task Board API.
- Gain practical experience in creating, editing, and deleting tasks programmatically via an API.
- Learn how to document API responses in a professional and reproducible way, suitable for GitHub submission.
