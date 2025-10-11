# 🗄️ Homework: Databases

### Course: Software Technologies @ Software University  
**Assignment Type:** Practical SQL Exercises  
**Submission:** Complete all tasks and include SQL scripts as evidence.

---

## 🏷️ Part 1: Address Database

### Objective
Practice creating databases, tables, and executing SQL queries to retrieve specific data.

### Steps

1. **Create the Database**
   - Create a new database named `address_database` and switch to it:  
```sql
CREATE DATABASE address_database;
USE address_database;
```
---

2. **Create the Table**
   - Create a table named addresses with the following columns:
 ```
  CREATE TABLE addresses (
    street_number INT,
    street_name VARCHAR(100),
    area VARCHAR(100),
    town VARCHAR(100),
    district VARCHAR(100),
    country VARCHAR(100),
    continent VARCHAR(50)
);
```

---

3. **Add Boolean Column**
   - Add a Boolean column named isCapital to indicate if the city is a capital:
```
  ALTER TABLE addresses
ADD COLUMN isCapital BOOLEAN;
```

---

4. **Insert Records**
   - Insert multiple records into the addresses table with sample data:
  ```
INSERT INTO addresses (street_number, street_name, area, town, district, country, continent, isCapital)
VALUES 
(12, 'Maple Street', 'Downtown', 'Berlin', 'Mitte', 'Germany', 'Europe', TRUE),
(45, 'Oak Avenue', 'Uptown', 'Hamburg', 'Altona', 'Germany', 'Europe', FALSE),
(22, 'Sunset Blvd', 'Central', 'Buenos Aires', 'Palermo', 'Argentina', 'South America', TRUE),
(8, 'Elm Street', 'Northside', 'Lisbon', 'Lisboa', 'Portugal', 'Europe', TRUE),
(19, 'Pine Lane', 'West End', 'Porto', 'Porto', 'Portugal', 'Europe', FALSE);
```

---

5. **Query: Addresses in Capital Cities**
```
SELECT * FROM addresses
WHERE isCapital = TRUE;
```

--- 

6. **Query: Addresses in South America**
```
SELECT * FROM addresses
WHERE continent = 'South America';
```

--- 

7. **Query: Addresses in Europe (Non-Capitals)**
```
SELECT * FROM addresses
WHERE continent = 'Europe' AND isCapital = FALSE;
```

---
