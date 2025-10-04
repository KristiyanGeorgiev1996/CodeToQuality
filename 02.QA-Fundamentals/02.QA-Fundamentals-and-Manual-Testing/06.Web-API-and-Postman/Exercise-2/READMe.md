# Task Board API Practice - Postman Homework

## Project Description
This exercise focuses on using Postman to interact with the Task Board system API. The goal is to practice sending requests, receiving responses, and understanding how task management works via the RESTful API.

The API allows you to:
- View all boards
- View all tasks
- View tasks by board
- Search tasks by keyword
- Create a new task
- Edit an existing task
- Delete a task

All examples use **example URLs** and **JSON responses** to simulate interaction without running the application.

---

## API Requests and Example Responses

### 1. Get All Boards
**Request:** `GET https://taskboard.example.com/api/boards`  

**Response:**
```json
[
    { "id": 1001, "name": "Open" },
    { "id": 1002, "name": "In Progress" },
    { "id": 1003, "name": "Done" }
]
```

### 2. Get All Tasks

**Request:** GET https://taskboard.example.com/api/tasks

**Response:**
```json
[
    { "id": 1, "title": "Project skeleton", "board": { "id": 1003, "name": "Done" } },
    { "id": 2, "title": "Home page", "board": { "id": 1003, "name": "Done" } },
    { "id": 3, "title": "View task board", "board": { "id": 1002, "name": "In Progress" } }
]
```

### 3. Get Tasks from Board "Done"

**Request:** GET https://taskboard.example.com/api/tasks/board/Done

**Response:**
```json
[
    { "id": 1, "title": "Project skeleton", "board": { "id": 1003, "name": "Done" } },
    { "id": 2, "title": "Home page", "board": { "id": 1003, "name": "Done" } }
]
```

### 4. Find Tasks by Keyword "home"

**Request:** GET https://taskboard.example.com/api/tasks/search/home

**Response:**
```json
[
    { "id": 2, "title": "Home page", "board": { "id": 1003, "name": "Done" } }
]
```

### 5. Create a New Task

**Request:** POST https://taskboard.example.com/api/tasks
**Body:**
```json
{
    "title": "New Task",
    "description": "Example task",
    "board": "Open"
}
```

**Response:**
```json
{
    "id": 4,
    "title": "New Task",
    "description": "Example task",
    "board": { "id": 1001, "name": "Open" },
    "dateCreated": "2025-10-04T15:55:39.909Z",
    "dateModified": "2025-10-04T15:55:39.909Z"
}
```

### 6. Edit Existing Task

**Request:** PATCH https://taskboard.example.com/api/tasks/4
**Body:**
```json
{
    "title": "Updated Task"
}
```

**Response:**
```json
{
    "msg": "Task edited.",
    "task": {
        "id": 4,
        "title": "Updated Task",
        "description": "Example task",
        "board": { "id": 1001, "name": "Open" },
        "dateCreated": "2025-10-04T15:55:39.909Z",
        "dateModified": "2025-10-04T16:11:33.482Z"
    }
}
```

### 7. Delete Existing Task

**Request:** DELETE https://taskboard.example.com/api/tasks/4
**Response:**
```json
{
    "msg": "Task deleted: 4"
}
```

---

**Summary**

- This exercise allows you to:
- Practice using Postman to send GET, POST, PATCH, and DELETE requests.
- Understand the structure of JSON response objects.
- Gain experience in simulating task creation, editing, and deletion via API.
- Document API responses professionally for GitHub submission.
