# 🧪 Test Automation Architectures Lab

This project explores **Test Automation Architectures** using Selenium, Selenium Grid, Selenoid, and BrowserStack with C# and NUnit. The goal is to understand distributed automation, cross-browser testing, and parallel execution while practicing real-world automation strategies.  

The lab contains two main projects. The first is **PracticeProject**, a simple web application designed for exploration and hands-on practice. Its functionality is straightforward, focusing on front-end automation scenarios like page navigation and CRUD operations. You can run it locally with `CTRL + F5` to verify the correct URL before executing tests. The second project is **TestProject**, which contains example Selenium tests for the PracticeProject. One test verifies that the page title matches the expected value, while another creates a new entity and validates its presence in the home page table. Both tests can be debugged, extended, and modified to practice different automation strategies.

Selenium Grid is integrated to enable running tests across multiple browsers and operating systems simultaneously. By replacing local IWebDriver instances with RemoteWebDriver and configuring ChromeOptions or EdgeOptions, tests can connect to the Grid URL at `http://localhost:4444`. This setup allows executing tests in parallel and viewing live sessions on the Grid Console. With Selenium Grid, the need for multiple local machines is eliminated, and test execution speed is significantly improved while ensuring cross-browser coverage.

Selenoid offers a lightweight alternative to Selenium Grid using Docker containers to run browser instances. By installing Docker Desktop and the Selenoid Configuration Manager, you can start Selenoid with VNC support and monitor sessions via the Selenoid UI. NUnit tests can be configured with `[TestFixture]` attributes to define browser and version combinations. RemoteWebDriver points to the Selenoid URL, enabling execution of tests like searching Wikipedia or validating page elements. Selenoid simplifies distributed testing, reduces infrastructure overhead, and provides visual feedback for sessions.

BrowserStack allows executing tests on more than 3000 real devices and desktop browsers in the cloud. After signing up, obtaining your username and access key, and configuring the `browserstack.yml` file, tests can be run against multiple desktop and mobile environments. This ensures real-world cross-browser and cross-device coverage without relying on local infrastructure. BrowserStack combined with NUnit allows seamless integration of automated regression tests into cloud pipelines.

Throughout this lab, students gain hands-on experience running tests locally, on distributed grids, within containerized environments, and in cloud platforms. Tests can be extended to cover additional entities and UI elements, multiple browser versions, and operating systems. Parallel execution strategies and session management can be explored, while integration into CI/CD pipelines demonstrates real-world applicability.  

This lab highlights key concepts in scalable test automation including distributed testing, cross-browser compatibility, remote execution, and efficient test management. It provides a practical foundation for building robust automation architectures using modern tools and frameworks.

---

### 📖 References

Selenium Documentation, Selenium Grid Guide, Selenoid GitHub, BrowserStack Automate, NUnit Documentation  

---

### 💡 Tips

Extend tests for additional elements, verify multiple browsers and operating systems, explore parallel execution strategies, and integrate into CI/CD pipelines for fully automated regression testing.  

### ⚙️ Keywords

Selenium, Selenium Grid, Selenoid, BrowserStack, RemoteWebDriver, NUnit, Parallel Testing, Cross-Browser, C#, Automation Architecture
