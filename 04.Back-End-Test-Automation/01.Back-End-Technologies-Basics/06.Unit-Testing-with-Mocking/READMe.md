# 🧪 Unit Testing with Mocking – Lecture Overview

## 🌐 1. Unit Testing and Dependencies

Unit Testing is the practice of testing individual modules or components of an application to ensure they work correctly.

- Each module is tested in isolation, independent of the rest of the system.  
- Dependencies such as databases, external services, or file systems can affect tests, so **mocking** is used to isolate them. ⚙️

---

## 🔹 2. What is Mocking?

Mocking is a technique for creating **simulated objects** that imitate the behavior of real dependencies. This allows testing the logic of a module without using actual external resources.

---

## 🔹 3. What to Mock?

- External services such as APIs and databases  
- Time-dependent functionalities (e.g., current time)  
- Configuration files and settings  
- Any functionality that may affect the predictability of the test

---

## 🧩 4. Moq Framework

Moq is a popular **.NET framework** that simplifies the creation of mock objects. It allows:  
- Implementing interfaces and classes with predefined behaviors  
- Setting expected results and verifying method calls

---

## 💻 5. Using Moq Framework in C#

With the Moq framework, we can create mock objects and configure their behavior during unit tests. Core features include:  
- **Setup** – define the behavior of the mock  
- **Verify** – check whether certain methods were called  
- **Returns** – set expected return values for method calls

---

## 📦 6. Moq.EntityFrameworkCore

Moq.EntityFrameworkCore is an extension for Moq that allows easy **mocking of DbContext and DbSet** in Entity Framework Core. This enables unit testing of business logic interacting with the database without a real database.

---

### 🏁 Conclusion

Unit Testing with Mocking ensures reliability and predictability of tests, allowing isolated component testing. Moq and Moq.EntityFrameworkCore provide powerful tools to simulate dependencies and verify code behavior. 🚀
