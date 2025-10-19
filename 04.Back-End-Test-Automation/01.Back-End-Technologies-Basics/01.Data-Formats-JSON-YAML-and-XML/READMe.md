# 📂 Data Formats – Lecture Overview  

## 🌐 1. Data Formats Introduction  

Data formats are standardized ways to store, represent, and exchange data between different systems and applications. Choosing the appropriate format affects readability, processing, and data efficiency. 💾  

---  

## 🗂️ 2. Structured, Unstructured, and Semi-Structured Data  

- **Structured Data** – organized in tables or databases, easy to process (e.g., SQL tables).  
- **Unstructured Data** – free text, images, videos with no predefined structure.  
- **Semi-Structured Data** – has some organization but not strictly structured, e.g., JSON and XML.  

---  

## 📊 3. Understanding Common Data Formats: JSON, YAML, XML  

These formats are widely used for exchanging data between applications and systems. Key characteristics include:  
- **JSON** – easy to read and write, popular in web applications.  
- **YAML** – designed for configuration files, human-readable and concise.  
- **XML** – extensible and self-descriptive, used in older systems and complex structures.  

---  

## 🔹 4. JSON Data Format  

- JSON (JavaScript Object Notation) represents data as key-value pairs.  
- Easy to understand and parse in various programming languages.  
- Example:  
```json
{
  "name": "Alice",
  "age": 25,
  "city": "Sofia"
}
```

---

## 🔹 5. YAML Data Format
- YAML (YAML Ain’t Markup Language) is human-friendly, using indentation instead of braces.
- Suitable for configuration files and data that need to be easily readable.

Example:
```
name: Alice
age: 25
city: Sofia
```

---

## 🔹 6. XML Documents
- XML (eXtensible Markup Language) uses tags to define data structure.
- Supports complex hierarchies and metadata.

Example:
```
<person>
  <name>Alice</name>
  <age>25</age>
  <city>Sofia</city>
</person>
```

---

## ⚖️ 7. Data Formats Comparison

| Format | Readability | Complexity | Usage | Examples |
|--------|------------|-----------|-------|---------|
| JSON   | High       | Low       | Web applications | API responses |
| YAML   | Very High  | Low       | Configurations    | DevOps files |
| XML    | Medium     | High      | Legacy software, complex structures | SOAP, documents |

**Summary:**

- JSON is most popular for web and APIs  
- YAML is convenient for configuration and human readability  
- XML is suitable for complex and extensible structures
