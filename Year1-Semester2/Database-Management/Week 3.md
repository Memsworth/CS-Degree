# 1. Data Models

A **data model** helps distinguish databases based on their underlying structure. It provides a **collection of conceptual tools** for describing data semantics, structure, and constraints.

## Record-Based Models
> **Relational model + Hierarchical model + Network model = Record-based data models**

## 1.1 Relational Model
- Proposed by **E.F. Codd**
- Data is represented in **tables (relations)**
- Structure: *tables → rows → columns*

## 1.2 Entity–Relationship (ER) Model
- A **higher-level conceptual data model**
- Based on:
  - **Entities** → real-world objects  
  - **Attributes** → properties of entities  
  - **Relationships** → associations among entities
- Tools used: e.g., **Microsoft Visio**, Lucidchart, Draw.io

## 1.3 Object-Based Data Model
- Extension of the ER model
- Adds object-oriented concepts:
  - **Encapsulation**
  - **Methods**
  - **Objects (with types)**
- Supports **structure types** and **collection types**
- Used in:
  - Engineering design  
  - Manufacturing  
  - Telecommunications  
  - GIS (Geographical Information Systems)

## 1.4 Object-Relational Data Model
- Combines **object** and **relational** models
- *How?*
  - Adds **type systems** to relational databases
  - Applications built as **objects** but stored as **relations**
- Suitable for:
  - Complex data  
  - Multimedia data  

## 1.5 Semi-Structured Data Model
- Same type of data **may not share the same attributes**
- Flexible structure
- Often represented using **XML**, **JSON**

## 1.6 Hierarchical Model
- Primitive model using **tree structure**
- Each child has **only one parent**
- Represents **one-to-many** relationships

## 1.7 Network Model
- Primitive model based on **graphs**
- A record can have:
  - One parent and many children
  - Many-to-many relationships  

# 2. Types of Database Users

### 1) Naive Users
- Use predefined applications to interact with the DB

### 2) Application Programmers
- Professionals who write application programs using the DB

### 3) Sophisticated Users
- Use query languages directly for analysis and reporting  
  (e.g., analysts, data scientists)

### 4) Specialized Users
- Create specialized DB applications  
  (e.g., CAD systems, expert systems)

# 3. Database Administrator (DBA)

A **DBA** is the central authority controlling data access and database operations.

### Responsibilities
- **Schema Definition**
- **Storage Structure & Access Method Definition**
- **Schema & Physical Organization Modification**
- **Authorization Management**
- **Routine Maintenance**

# 4. Types of DBMS

## 4.1 Based on Data Model
- **Relational DBMS (RDBMS)**
- **Object-Oriented DBMS (OODBMS)**
- **Object-Relational DBMS (ORDBMS)**

## 4.2 Based on Number of Sites
- **Centralized DBMS**
- **Distributed DBMS**
  - **Homogeneous**
  - **Heterogeneous**

## 4.3 Based on Number of Users
- **Single-user**
- **Multi-user**

## 4.4 Relational DBMS
- Based on relational model  
- Data stored as **tables**
- Supports: INSERT, UPDATE, DELETE

## 4.5 Object-Oriented DBMS
- Stores **data as objects**
- Supports:
  - Classes  
  - Objects  
  - Polymorphism  
  - Encapsulation

## 4.6 Object-Relational DBMS
- Mix of relational and object features  
- SQL is extended (e.g., PostgreSQL)

# 5. Data Manipulation Language (DML)

Commands: **SELECT, INSERT, UPDATE, DELETE**

## 5.1 SELECT
```sql
SELECT *
FROM Students;
```

### SELECT DISTINCT
```sql
SELECT DISTINCT department
FROM Students;
```


### WHERE Clause
```sql
SELECT name, marks
FROM Students
WHERE marks > 80;
```

## 5.2 INSERT
### 1. Insert into specific columns
```sql
INSERT INTO Students (name, age)
VALUES ('Ali', 20);
```

### 2. Insert into all columns
```sql
INSERT INTO Students
VALUES (101, 'Ali', 20, 'CS');
```

## 5.3 UPDATE
```sql
UPDATE Students
SET marks = 95
WHERE student_id = 101;
```

## 5.4 DELETE
```sql
DELETE FROM Students
WHERE student_id = 101;
```
