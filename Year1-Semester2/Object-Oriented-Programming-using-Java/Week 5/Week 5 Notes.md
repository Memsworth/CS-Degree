

## What is Polymorphism?

**Polymorphism** means *“many forms.”*  
In object-oriented programming, polymorphism allows the **same interface** (method name or behavior) to be used for **different data types or objects**.

> One interface, multiple implementations.

---

## Example: Stack

A **Stack** always has the same operations:
- push
- pop

But the **data type** can differ:
- Integer
- Floating point
- Character

Using **generics**:

``` java
Interface Stack<T>  
- void push(T value)  
- void pop(T value)
```

> The behavior stays the same, but the data type changes.

---

## Types of Polymorphism

There are two main types:

1. **Static Polymorphism (Compile-Time)**
2. **Dynamic Polymorphism (Run-Time)**

---

## Lecture 1: Static vs Dynamic Polymorphism

### Static Polymorphism (Compile-Time)

- Resolved during **compilation**
- Also called **static binding**
- Achieved using:
  - Function overloading
  - Method overloading

> The compiler decides which method to call.

---

### Dynamic Polymorphism (Run-Time)

- Resolved during **runtime**
- Also called:
  - Dynamic binding
  - Dynamic Method Dispatch
- Achieved using:
  - Method overriding

> The JVM decides which method to call based on the **object type**.

---

## Lecture 2: Static Polymorphism (Method Overloading)

### Method Overloading

Occurs when:
- Methods have the **same name**
- But **different parameters**

Differences can be:
- Number of parameters
- Data types
- Order of parameters

Example:
```java
int add(int a, int b)  
double add(double a, double b)  
int add(int a, int b, int c)
```


---

### How Overloading Works

- Compiler matches arguments with parameters
- Match does not have to be exact
- Type conversion may occur

---

### Advantages of Method Overloading

- One interface, multiple implementations
- Cleaner and more readable code
- Reduces code duplication
- Common in Java (e.g., abs())
- Good practice when used appropriately

---

## Lecture 3: Dynamic Polymorphism (Method Overriding)

### Method Overriding

Occurs when:
- A subclass method has the **same name**
- Same parameters
- Same return type
- As a method in the superclass

Method call depends on the **object type**, not the reference type.

---

### Key Rules

- Subclass method is called
- Superclass method is hidden
- Private methods cannot be overridden
- Requires inheritance

---

```java
Class Animal  
- void sound()

Class Dog extends Animal  
- void sound()
```

> If an Animal reference refers to a Dog object, the Dog’s sound() method runs.

---

### Important Keywords

- **extends** – used for inheritance  
- **super** – used to access superclass methods  
  Example: super.methodName()

---

## Lecture 4: Constructor Overloading

### Constructor Overloading

- Constructors can be overloaded
- Same class, different parameter lists
- Allows flexible object creation

---

### Example
```java
Box mybox1 = new Box(10, 20, 15)  
Box mybox2 = new Box()  
Box mycube = new Box(7)
```

> The constructor that matches the arguments is invoked.

---