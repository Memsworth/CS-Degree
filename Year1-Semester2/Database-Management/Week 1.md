# Introduction to DBMS

## Database

Collection of interrelated data

## Management System

Manages data for convenience and efficiency

### Functions of a DBMS

- Define structure of data
- Provide data manipulation mechanisms
- Ensure data safety

### Data vs Information

- **Data:** Raw facts (numbers, text)
- **Information:** Processed / organized data

* * *

# DBMS Architecture (Layers)

- User
- Application
- DBMS
- Actual Database

* * *

# Applications of DBMS

- Enterprise: sales, accounts
- Banking: customer information
- Healthcare: blood bank, patient records
- University: student data
- Telecommunication: call records

* * *

# Examples of DBMS

- MySQL
- PostgreSQL

* * *

# Evolution Before DBMS

## Paper-Based System

- Manual intervention
- Time-consuming
- Prone to physical damage
- Security issues

## File Processing System (Hard Disk)

- Data stored in separate files
- More data → more files → overhead

* * *

# File Processing System (Detailed)

### Characteristics

- Each operation needs its own application

### Example: Hospital

- Doctors
- Payroll
- Staff
- Patients  
    Separate apps → overhead

* * *

# Disadvantages of File Processing System

- Difficulty in data access → solved by SQL
- Data redundancy → solved by integrity constraints
- Data isolation → solved by JOIN
- Atomicity issues → solved by ACID + logs
- Integrity issues → solved by entity/referential/domain integrity
- Concurrency issues → solved by locking, timestamps
- Security issues → solved by privileges, views

* * *

# SQL Overview

- Structured English Query Language (IBM)
- Case-insensitive
- Used for relational databases

* * *

# Relational Database

- Based on relational model
- Uses tables and relationships

## RDBMS

- Creates, modifies, updates, manages relational databases

* * *

# SQL Command Categories

## 1\. DDL (Data Definition Language)

- CREATE
- ALTER
- DROP

## 2\. DML (Data Manipulation Language)

- INSERT
- SELECT
- UPDATE
- DELETE

## 3\. Transaction Control

- COMMIT
- ROLLBACK

## 4\. Authorization

- GRANT
- REVOKE

* * *

# SQL Data Definition (DDL)

### Syntax

```
create table r (A1 D1, A2 D2, ... (constraints));  
```

### Example

```sql
create table emp (  
ID varchar(5),  
name varchar(50) not null,  
primary key (ID)  
);  
```

* * *

# DROP TABLE

```sql 
drop table r;  
```

* * *

# ALTER TABLE
```sql
1) Add Attribute:
	alter table r add A D;  

2) Remove Attribute:
	alter table r drop A;
```