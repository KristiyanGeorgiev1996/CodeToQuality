# 📱 Exercise II: Appium Mobile – Mobile Gestures

This project focuses on **automating mobile gestures** using Appium on Android devices. The main goal is to demonstrate how to perform and test interactions such as taps, swipes, scrolls, drag-and-drop, and zoom in/out on touch-enabled devices.  

---

## 🧩 Mobile Gestures Overview

Mobile gestures simulate physical interactions on smartphones and tablets to ensure **applications behave correctly**. These gestures are essential for enhancing user experience and for **automated mobile testing**.  

### Common Gestures:

- **Tap:** Quick touch, similar to a mouse click.  
- **Long Press:** Touch and hold an element.  
- **Swipe:** Quick movement across the screen (left, right, up, down).  
- **Scroll:** Move content up/down to reveal more items.  
- **Drag and Drop:** Press, move, and release an object to a new location.  
- **Zoom In/Out:** Two-finger gesture to adjust the zoom level.  

---

## 🛠 Appium Inspector – Interaction Modes

### Coordinates Mode

- Allows executing gestures directly on the device screen.  
- Top-left corner shows X/Y coordinates as you hover.  
- Switch between **Element Mode** and **Coordinates Mode** using the header buttons.  

### Performing Actions

- Tap, swipe, scroll, and drag-and-drop using coordinates.  
- Ensures precise interaction with mobile elements that may not have Accessibility IDs.  

---

## 🧪 Automated Tests Overview

### Test App: `ApiDemos-debug.apk`  

We perform gestures on this sample Android app to validate interactions.

---

### **1. Scroll Test**

**Steps:**

1. Open the app.  
2. Tap **Views**.  
3. Scroll down to **Lists** using `ScrollToText` method.  
4. Tap **Lists**.  
5. Verify the expected element `"10. Single choice list"` is displayed.  

**Key Concepts:**  
- Scrolls until text is visible using `UiScrollable` and `UiSelector`.  
- Continuous movement to navigate through content.  

---

### **2. Swipe Test**

**Steps:**

1. Tap **Views** → **Gallery** → **Photos**.  
2. Locate the first image.  
3. Perform a swipe left using Selenium `Actions`.  
4. Assert the third image is visible.  

**Key Concepts:**  
- Swiping is a quick gesture to navigate or trigger actions.  
- Different from scrolling, which is continuous.  

---

### **3. Drag and Drop Test**

**Steps:**

1. Tap **Views** → **Drag and Drop**.  
2. Press and hold the first red dot.  
3. Drag over the second red dot and release.  
4. Assert that `"Dropped!"` text appears.  

**Key Concepts:**  
- Simulates moving objects within the app.  
- Can be used for rearranging items or performing custom actions.  

---

### **4. Seek Bar Test**

**Steps:**

1. Tap **Views** → scroll to **Seek Bar**.  
2. Tap **Seek Bar**.  
3. Slide the bar using coordinates from Appium Inspector.  
4. Verify the displayed slider value.  

**Key Concepts:**  
- Press, move, and release gestures for sliders.  
- Commonly used for volume, brightness, or progress controls.  

---

### **5. Zoom In/Out Tests**

**Steps:**

1. Tap **Views** → scroll to **WebView**.  
2. Perform zoom-in gesture at specified coordinates.  
3. Perform zoom-out gesture by reversing the motion.  

**Key Concepts:**  
- Uses two-finger gestures to simulate pinch/spread.  
- Requires precise coordinates and speed control for realistic gestures.  

---

## 🧩 Gestures in Appium Inspector

### **Gestures Tab:**

- Save, edit, and run custom gestures.  
- "+" button to create new gestures.  
- Overlay shows actions visually on the screenshot.  

### **Gesture Builder:**

- Four parts: Header, Gesture Timeline, Pointer Tabs, Pointer Actions.  
- Actions include `move`, `pointer down`, `pointer up`, `pause`.  
- Supports up to 5 simultaneous pointers.  
- Allows using relative (%) or absolute (pixels) coordinates.  

---

## 🌟 Project Highlights

- Full automation of **mobile gestures** on Android emulators/devices.  
- Demonstrates **scroll, swipe, drag-and-drop, seek bar sliding, and zoom gestures**.  
- Coordinates Mode ensures precise control of gesture execution.  
- Reusable test methods for scalable mobile UI automation.  
- Can be adapted for CI/CD pipelines or physical Android devices.  

---

## 📌 Notes

- Tests mirror exactly what happens on the emulator.  
- Appium Inspector is used for **element inspection and coordinate-based gestures**.  
- Accurate gesture simulation is critical for mobile UI testing.  

---

## 📖 References

- [Appium Documentation](https://appium.io/docs/en/about-appium/intro/)  
- [Appium C# Client](https://github.com/appium/appium-dotnet-driver)  
- [NUnit Documentation](https://docs.nunit.org/)  
- [ApiDemos Android App](https://github.com/appium/sample-code/tree/master/sample-code/apps/ApiDemos)  

---

💡 **Tip:** Extend your tests by combining gestures, testing multi-touch interactions, and verifying gesture results across multiple devices for complete coverage.
