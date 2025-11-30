
# Week 3 Notes: Controls & Classes
## 1. Control Statements

Control statements direct the flow of execution based on certain conditions or states.

### Categories of Control Statements

- **Selection**: `if`, `switch`
- **Iteration**: `for`, `while`, `do-while`
- **Jump**: `break`, `continue`, `return`

---

## 2. Selection Statements

Selection statements control program flow based on conditions.

### 2.1 If Statement

The `if` statement executes a block of code if a specified condition is true.

```java
int number = 10;
if (number > 5) {
    System.out.println("Number is greater than 5");
} else {
    System.out.println("Number is 5 or less");
}
```

### 2.2 Switch Statement

The `switch` statement is a multi-way branch that evaluates an expression and executes the matching `case`.  
- Expression type must be one of: `byte`, `short`, `int`, `char`, `String`
- If no `break` is used, execution continues to the next `case`

```java
int day = 3;
switch (day) {
    case 1:
        System.out.println("Monday");
        break;
    case 2:
        System.out.println("Tuesday");
        break;
    case 3:
        System.out.println("Wednesday");
        break;
    default:
        System.out.println("Invalid day");
}
```

### 2.3 Switch vs If Statement

| Feature                    | Switch                         | If                        |
|----------------------------|--------------------------------|---------------------------|
| **Checks equality**         | ✅                             | ❌ (can check any boolean expression) |
| **Data types**              | Limited (`int`, `char`, `String`) | Any boolean condition      |
| **Efficiency**              | More efficient for multiple equality checks | Can handle complex conditions |

---

## 3. Iteration Statements

Iteration statements (loops) repeatedly execute a block of code.

### 3.1 While Loop

The `while` loop executes a block of code as long as a condition is true.

```java
int i = 0;
while (i < 5) {
    System.out.println("i = " + i);
    i++;
}
```

### 3.2 Do-While Loop

The `do-while` loop executes the block of code **at least once** before checking the condition.

```java
int j = 0;
do {
    System.out.println("j = " + j);
    j++;
} while (j < 5);
```

### 3.3 For Loop

The `for` loop is designed for iterating through sequences like arrays or ranges.

```java
for (int k = 0; k < 5; k++) {
    System.out.println("k = " + k);
}
```

#### 3.4 Enhanced For Loop (For-Each)

The enhanced `for` loop iterates through elements of an array or collection.

```java
int[] numbers = {1, 2, 3, 4, 5};
for (int num : numbers) {
    System.out.println(num);
}
```

---

## 4. Jump Statements

Jump statements transfer control immediately to another part of the code.

### 4.1 Break

The `break` statement terminates the closest loop or `switch` statement.

```java
for (int i = 0; i < 10; i++) {
    if (i == 5) {
        break; // exit loop when i is 5
    }
    System.out.println(i);
}
```

### 4.2 Continue

The `continue` statement skips the current iteration and proceeds with the next iteration of the loop.

```java
for (int i = 0; i < 5; i++) {
    if (i == 2) {
        continue; // skip when i is 2
    }
    System.out.println(i);
}
```

### 4.3 Return

The `return` statement exits from the current method and optionally returns a value.

```java
public int add(int a, int b) {
    return a + b;
}
```

---

## 5. Classes in Java

A class is a blueprint or template for creating objects.
- It can be thought of as a **custom data type**.
- It contains **instance variables** (properties) and **methods** (functions).

### 5.1 Example of a Class

```java
public class Car {
    // Instance variables
    String color;
    String model;
    
    // Constructor
    public Car(String color, String model) {
        this.color = color;
        this.model = model;
    }
    
    // Method
    public void displayInfo() {
        System.out.println("Car Model: " + model + ", Color: " + color);
    }
}
```
### 5.2 Example of Using the Class

```java
public class Main {
    public static void main(String[] args) {
        Car myCar = new Car("Red", "Toyota");
        myCar.displayInfo(); // prints: Car Model: Toyota, Color: Red
    }
}
```
