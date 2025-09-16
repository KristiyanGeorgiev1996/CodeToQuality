# 🌐 Web API & Postman

**API (Application Programming Interface)** is an interface that allows different software components to communicate with each other. In the web context, these are called **Web Services**, exchanging data via HTTP and using formats like **JSON** or **XML**. 📡

**RESTful APIs** are the most popular web service standard. They are lightweight, fast, and operate through unique URLs for each resource. Key principles:

* **Stateless** – the server does not store client state between requests
* **Resource-based URLs** – each resource has a unique address

---

## 🔹 HTTP Basics

The HTTP protocol works on a **request–response** model: the client sends a request to the server, and the server responds with data.

Main HTTP methods for APIs:

* **GET** – retrieve data
* **POST** – create a resource
* **PUT / PATCH** – modify a resource
* **DELETE** – delete a resource

In GitHub API, these methods are used to manage repositories, issues, commits, and pull requests. 🛠️

---

## 🔹 JSON & XML

Data exchange formats include **JSON** and **XML**. JSON is lightweight, human-readable, and easy to parse, while XML is more structured and strict.

---

## 🔹 Working with GitHub REST API

GitHub provides a public API for accessing and managing repositories. It allows reading data, creating, and editing resources.

Modifications and resource creation require **authentication** via a personal token. 🔑

---

## 🔹 Postman for GitHub API

**Postman** is a tool for creating, sending, and testing HTTP requests. It enables:

* Quick testing of GitHub API
* Creating collections of requests
* Using variables for authentication and parameters
* Automation and documentation

---
