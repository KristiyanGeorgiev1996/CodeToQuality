# 🐳 Containers, Docker and Docker Compose – Lecture Overview

## 🌐 1. Containerization Overview

Containerization is a technology for isolating applications and their dependencies in self-contained environments. This allows applications to run consistently across different environments – local machines, servers, or cloud platforms – without compatibility issues. ⚙️

### Benefits:
- Lightweight and fast application startup
- Process isolation
- Easy portability between environments

---

## 🐳 2. Docker

Docker is a leading platform for containerization, enabling the creation, deployment, and management of containers. It provides standardized tools and interfaces for working with containers, ensuring applications run the same everywhere.

---

## 💻 3. Docker CLI

The Docker CLI (Command Line Interface) is the main tool for interacting with Docker. With it, you can:
- Start and stop containers
- View running containers
- Manage images and networks

---

## 📁 4. File System and Volumes

Containers have their own filesystem, isolated from the host. **Volumes** are used to persist data even if the container is removed.

---

## 📝 5. Dockerfile

A Dockerfile is a text file containing instructions to build a Docker image. It specifies:
- Base image
- Dependencies installation
- File copying
- Application start commands

---

## 🏗️ 6. Building a Custom Image

Dockerfiles allow creating **custom images** that include the application and all dependencies. These images can be used to start containers anywhere.

---

## 🌐 7. Container Networking

Containers can communicate through different types of networks:
- Bridge network
- Host network
- Overlay network

---

## ⚙️ 8. Orchestration Overview

Orchestration is the process of automatically managing multiple containers – starting, stopping, scaling, and monitoring. It is essential for complex applications with multiple services.

---

## 📦 9. Docker Compose Orchestration Tool

Docker Compose is a tool for orchestrating multiple containers via a single YAML file. It allows:
- Defining multiple services
- Connecting containers through networks
- Configuring volumes and environment variables

---

### 🏁 Conclusion

Containerization with Docker and Docker Compose simplifies development, deployment, and management of modern applications. It ensures isolation, portability, and easy orchestration of multiple services. 🚀
