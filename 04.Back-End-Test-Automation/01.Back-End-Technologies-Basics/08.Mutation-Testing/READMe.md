# 🧬 Mutation Testing – Lecture Overview

## 🌐 1. Mutation Testing Introduction

Mutation Testing is a technique used to evaluate the **quality and effectiveness of unit tests** by deliberately introducing small changes ("mutations") into the code. The goal is to check whether existing tests can catch errors and ensure code reliability. ⚡

---

## 🔹 2. Types of Mutation Testing

- **Traditional Mutation Testing** – mutations are introduced manually or via tools, and tests are checked to see if they catch the errors.  
- **Weak Mutation Testing** – a test is considered successful if the mutation affects expressions, even if it does not impact the final output.  
- **Strong Mutation Testing** – a test must detect the mutation and ensure it affects the program’s final output.  

---

## 🛠️ 3. Tools for Mutation Testing

There are tools that automate mutation testing, generating mutations and reporting the effectiveness of tests. One of the popular tools is **Stryker**.

### Stryker – Installation, Usings, Metrics

- **Installation** – easy to install via package managers.  
- **Usings** – integrates with .NET and other popular testing languages.  
- **Metrics** – provides information on the percentage of killed mutations and weaknesses in the test suite.  

---

## 🏁 4. Mutation Testing Wrap-Up

Mutation Testing is a powerful method for assessing test quality. It helps developers identify **weak spots in test code** and improve the reliability of the application. 🚀
