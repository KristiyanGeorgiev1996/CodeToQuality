# Task Board – Project

This document summarizes the functional and non-functional requirements of the Task Board project, adapted to reflect my own implementation. It is structured to highlight the implemented functionalities without revealing protected or copyrighted information.

## Overview

Task Board is a web application for task management. It provides features for creating, viewing, editing, and searching tasks, as well as organizing tasks by boards. The application also includes a Web API for advanced users to interact programmatically.

For testing purposes, the original Task Board applications were provided as follows:

- **Task Board v.01**  
  Forked into my own profile for testing.

- **Task Board v.02**  
  Re-tested after developer fixes.

The following sections summarize the functionalities implemented and tested in my solution.

## Functional Requirements

### Home Page
- Displays the total number of tasks available in the system.
- Greeting message for the user.
- Consistent side menu on all pages with options: Home, Task Board, Create, Search.
- Quick access buttons for Task Board, Create Task, Search Tasks, and RESTful API.

### Task Board Page
- Tasks are displayed organized by boards in the order: Open, In Progress, Done.
- Each task includes a title, brief description, and action buttons "View" and "Edit."

### Task Creation
- Users can create new tasks by providing a title, optional description, and selecting a board.
- Title is mandatory and validated to prevent empty tasks from being created.

### Task Viewing
- Users can view the full details of a task by clicking the "View" button.

### Task Editing
- Users can edit the title, description, or move the task to a different board.
- Changes are saved via the "Edit" button.

### Task Searching
- Users can search for tasks by keyword.
- Results display task title, board name, and brief description.
- Displays the total number of matching tasks found.

### Web API
- Provides endpoints for CRUD operations on tasks (accessed via Quick Access buttons).

## Non-Functional Requirements
- **Usability**: User-friendly interface with clear navigation.
- **Performance**: Tasks load quickly, and search returns results in a timely manner.
- **Security**: Task creation and editing are performed over secure connections.

## Implementation Notes
- Test cases were created based on the above functionalities.
- Bugs found during testing were documented.
- All functionalities were validated against the forked versions of Task Board v.01 and v.02.

---

This documentation serves as a reference for the implemented solution and demonstrates compliance with the core functionalities of Task Board while preserving intellectual property rights.
