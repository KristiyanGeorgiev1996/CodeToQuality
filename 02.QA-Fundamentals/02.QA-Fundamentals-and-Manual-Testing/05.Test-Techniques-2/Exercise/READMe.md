# Homework: Test Techniques – Income Checker & eCommerce

## 1. Equivalence Partitioning / Boundary Value Analysis – Income Checker

**Task Description:**  
The purpose of this exercise is to apply Equivalence Partitioning and Boundary Value Analysis techniques to a simple Income Checker application. The app categorizes monthly income into three categories: "low", "mid", and "high". It also handles invalid input, such as negative numbers.  

The functionality works as follows:  
- Returns "low" for income below 1000  
- Returns "mid" for income between 1000 (inclusive) and 3000 (exclusive)  
- Returns "high" for income equal to or above 3000  
- Returns "error" for negative income  

**Your Task:**  
1. **Equivalence Partitioning:** Divide all possible income values into valid and invalid partitions.  
2. **Boundary Value Analysis:** Identify the edge values at the boundaries of these partitions and create test cases covering those boundaries.  
3. Consider all realistic scenarios, including unexpected or invalid inputs, to ensure robust testing.  

### Equivalence Partitioning Test Cases (Including Invalid Cases)

| Test Case ID | Input       | Expected Output |
|--------------|------------|----------------|
| TC01         | 500        | "low"          |
| TC02         | 1856       | "mid"          |
| TC03         | 562412545  | "high"         |
| TC04         | 0          | "low"          |
| TC05         | -20        | "error"        |
| TC06         | 596        | "low"          |

### Boundary Value Analysis Test Cases (Including Invalid Cases)

| Test Case ID | Input            | Expected Output                                                                 |
|--------------|-----------------|-------------------------------------------------------------------------------|
| TC07         | 999             | "low"                                                                          |
| TC08         | 1000            | "mid"                                                                          |
| TC09         | 2999            | "mid"                                                                          |
| TC010        | 3000            | "high"                                                                         |
| TC011        | 1832`56         | "Cannot enter the symbol." "high"                                              |
| TC012        | 586,20          | "low"                                                                          |
| TC013        | 305400.65       | "high"                                                                         |
| TC014        | one hundred dollars | "It displays the letter 'e' and does not allow further input. It prompts that a number should be entered." |
| TC015        | 2541 56         | "Cannot enter the space." "high"                                              |
| TC016        | 52542/56        | "It is not possible to enter the special character." "high"                   |

---

## 2. Pairwise Testing – eCommerce Checkout Function

**Task Description:**  
This exercise focuses on using Pairwise Testing to reduce the number of necessary test cases for an eCommerce checkout function. The checkout contains the following input fields:  

- A drop-down menu with several shipping methods  
- A radio button for gift wrapping options  
- A checkbox for agreeing to terms and conditions  
- A final "Place Order" button  

**Your Task:**  
1. Calculate how many positive test cases would be required if every possible combination is tested.  
2. Apply Pairwise Testing to minimize the number of necessary test cases while still covering all pairwise combinations.  
3. Add a screenshot of the reduced test cases.  
4. Write at least three negative test cases to cover invalid input scenarios.  

### Positive Test Cases Calculation

- Total positive test cases if all possibilities are covered: **20**

### Reduced Test Cases Screenshot

Using Pairwise testing, the number of necessary test cases was reduced.  
The screenshot of the reduced test cases is shown below:

![Pairwise Test Cases Screenshot](screenshot.png)

### Negative Test Cases

1. Attempt to place an order with no shipping method selected.  
2. Attempt to place an order with an invalid shipping method selection.  
3. Invalid selection for gift wrapping.  
4. Invalid status of the checkbox.  
