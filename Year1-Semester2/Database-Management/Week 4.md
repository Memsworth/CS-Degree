

## 1. History of the Relational Model
- The relational model was introduced by **E. F. Codd**.
- It represents data using **record-based structures**, stored as **relations** (tables).
- A *relation* corresponds to a *table* in modern database systems.

---

## 2. Basic Terminology

### Relation
- A *relation* = a *table*  
- A *row* = *tuple* = *record*  
- A *column* = *attribute*  
- A *cell* = *field*

### Additional Terms
- **Cardinality**: Number of rows in a relation.
- **Degree**: Number of attributes (columns).
- **Domain**: Set of allowable values for an attribute.

### Relation Schema
Structure of a relation.

Example:  
`Employee(EID, EName, Dept, Place, Salary)`

---

## 3. Keys in a Relational Model

### Superkey
- A set of attributes that uniquely identifies a tuple.
- Adding attributes keeps it a superkey.
- Number of possible superkeys for *n* attributes: `2^n – 1`.

### Candidate Key
- A minimal superkey (no attribute can be removed).

### Primary Key
- A candidate key chosen to uniquely identify tuples.

### Alternate Key
- All candidate keys except the primary key.

### Composite Key
- A key formed using **two or more** attributes.

### Foreign Key
- The primary key from one relation used as a non-unique attribute in another.
- Ensures referential integrity.

---

## 4. Codd’s 13 Rules (RDBMS Requirements)

### Rule 0 – Foundation Rule
A system qualifies as an RDBMS only if it manages data through the relational model.

### Rule 1 – Information Rule
All data must be represented as values in tables.

### Rule 2 – Guaranteed Access Rule
Every data item must be accessible using:
- Table name  
- Primary key  
- Attribute name  

### Rule 3 – Systematic Treatment of Nulls
Nulls must be treated uniformly as:
- Missing  
- Unknown  
- Not applicable  

### Rule 4 – Dynamic Online Catalog
Database structure must be stored in an online catalog (data dictionary).

### Rule 5 – Comprehensive Data Sublanguage
Database must support a language that provides:
- Data definition  
- Data manipulation  
- Transaction management  

### Rule 6 – View Updating Rule
Updateable views must be updateable by the DBMS.

### Rule 7 – High-Level Insert, Update, Delete
Operations must support sets of rows, not just individual records.

### Rule 8 – Physical Data Independence
Physical storage changes must not affect data access.

### Rule 9 – Logical Data Independence
Changes in logical structure must not affect external views.

### Rule 10 – Integrity Independence
Integrity constraints must be definable in the database itself.

### Rule 11 – Distribution Independence
Data distribution across locations must be transparent to users.

### Rule 12 – Non-Subversion Rule
Low-level operations must not bypass security or integrity constraints.

---

## 5. Database Design Process

Design occurs in multiple phases:

### Phase 1: Initial (Requirement Analysis)
- Analyze user needs and output requirements.
- Collect high-level functional and data requirements.

### Phase 2: Conceptual Design
- Choose a data model (commonly the ER model).
- Create a **conceptual schema** via entities, attributes, and relationships.
- Represent schema using **ER diagrams**.

### Phase 3: Final Design

#### A. Logical Design
- Convert conceptual schema into relational schema.
- Choose DBMS-supported data model.

#### B. Physical Design
- Determine physical file structure:
  - File organization  
  - Indexing  
  - Storage layout  

### Common Design Issues
- **Redundancy** → causes inconsistency  
- **Incompleteness** → poor modeling and missing required data  

---

## 6. ER Model Overview

- Developed by **Peter Chen**.
- Used for conceptual database design before implementation.

### ER Model Components
- **Entities**  
- **Attributes**  
- **Relationships**  

### ER Diagram
A graphical representation of the logical structure of a database.

---

## 7. SQL Operators

### Comparison Operators
`= , > , < , >= , <= , <>`

#### Example
```sql
SELECT * FROM Employee WHERE Salary > 50000;  
```

---

### Logical Operators
`AND , OR , NOT`

#### Example
```sql
SELECT * FROM Employee  
WHERE Dept = 'HR' AND Salary < 40000;  
``` 

---

### Special Operators
- **IN**
- **BETWEEN**
- **LIKE**
- **IS NULL**

#### IN Example
```sql
SELECT * FROM Employee  
WHERE Dept IN ('HR', 'IT', 'Finance');  
``` 
#### BETWEEN Example
```sql
SELECT * FROM Employee  
WHERE Salary BETWEEN 30000 AND 60000;  
```
#### LIKE Example
```sql
SELECT * FROM Employee  
WHERE EName LIKE 'A%';  
``` 

#### IS NULL Example

```sql
SELECT * FROM Employee  
WHERE EName LIKE 'A%';  
```
---
