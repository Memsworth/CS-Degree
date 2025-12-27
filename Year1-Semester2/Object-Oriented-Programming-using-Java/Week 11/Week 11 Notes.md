# **Week 2 – Java: Datatypes, Variables, Type Conversions, and Arrays**

## **Java is Strongly Typed**
- Every variable in Java must have a declared **type**.
- Strong typing ensures **compatibility checking** at compile time.
- Prevents assigning values of the wrong type (e.g., assigning a `String` to an `int`).

---

## **Data Types in Java**

### **Primitive Data Types**
Primitive types store simple values—not objects.

| Type    | Size (bits) | Notes |
|---------|-------------|-------|
| `byte`  | 8           | Range: -128 to 127 |
| `short` | 16          | |
| `int`   | 32          | Default integer type |
| `long`  | 64          | Add `L` suffix for literals |
| `char`  | 16          | Stores a single Unicode character |
| `float` | 32          | Decimal values, use `f` suffix |
| `double`| 64          | Default floating type |
| `boolean` | JVM-dependent | true/false |

### **Reference Types**
- Objects, arrays, classes, interfaces, etc.
- Store **references** rather than actual data.

---

## **Variables**

### **Declaration**
Variables **must be declared before use**.

### **Initialization**
- **Static initialization:** value known at compile time.
- **Dynamic initialization:** value computed at runtime.

### **Variable Scope**
1. **Class Scope (Fields)** – declared inside a class, available to all methods unless restricted.
2. **Method Scope (Local Variables)** – declared inside methods or blocks, accessible only within those blocks.

---

## **Type Conversion and Casting**

### **Automatic Conversions (Widening Conversion)**
Occurs when:
1. Types are **compatible**.
2. Destination type has a **larger range**.

Examples:
- int → long  
- int → float  
- float → double  

### **Explicit Casting (Narrowing Conversion)**
Required when converting from large type to small type.

```java
(byte) variable
```

Risk of data loss.

### **Quick Exam Rule: int → byte**
```java
int a = 300;  
byte x = (byte) a;  
// x = a % 256  
// if result > 127 → subtract 256  
```

---

## **Java Ternary Operator**
A short form of an if–else.

```java
result = condition ? valueIfTrue : valueIfFalse;
```

---

## **Arrays in Java**

### **One-Dimensional Array**
```java
int[] numbers = new int[5];  
int[] values = {1, 2, 3, 4, 5};
```

### **Two-Dimensional Array**
```java
int[][] matrix = new int[3][3];  
int[][] grid = { {1,2}, {3,4}, {5,6} };
```
