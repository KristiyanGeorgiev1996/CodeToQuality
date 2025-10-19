# 📏 Code Coverage – Lecture Overview

## 1. What is Code Coverage?

Code Coverage is a metric used in software testing to **measure the extent to which the source code of a program is executed during testing**.  

- It helps determine which parts of the code have been tested and which remain untested.  
- High code coverage generally indicates better-tested and more reliable software. ⚡  
- It does not guarantee the absence of bugs, but it provides insights into test effectiveness.

---

## 2. Code Coverage vs Test Coverage

- **Code Coverage** – measures how much of the source code is executed during tests.  
- **Test Coverage** – measures which functionalities, features, or requirements are tested.  

While related, code coverage focuses on the **implementation details**, whereas test coverage focuses on **functional requirements**. 📊

---

## 3. Different Types of Code Coverage

There are several types of code coverage metrics used to assess testing quality:  

- **Line Coverage** – percentage of code lines executed during tests  
- **Branch Coverage** – percentage of possible decision branches (if/else) tested  
- **Function Coverage** – percentage of functions or methods executed  
- **Condition Coverage** – percentage of boolean expressions evaluated both true and false  

Using multiple types of coverage provides a comprehensive view of testing quality. ⚙️

---

## 4. Code Coverage in C#

In C#, code coverage can be measured using tools integrated with testing frameworks like **Visual Studio**, **Coverlet**, or **dotCover**.  

- These tools provide reports showing which lines, methods, and branches were tested.  
- Developers can identify untested parts of the application and improve test suites.  
- Integrates well with **unit testing frameworks** like NUnit, MSTest, or xUnit.  

---

## 5. Code Coverage in JavaScript

For JavaScript applications, code coverage can be analyzed using tools like **Istanbul/NYC**, **Jest**, or **Cypress**.  

- These tools track executed code during test runs and generate visual reports.  
- Helps ensure front-end and Node.js code is properly tested.  
- Can be integrated with CI/CD pipelines for automated coverage analysis. 🖥️

---

### 🏁 Conclusion

Code Coverage is a crucial metric for evaluating the effectiveness of tests and identifying untested areas of code.  

By combining coverage metrics with proper unit and integration tests, developers can **increase software reliability, maintainability, and quality**. 🚀
