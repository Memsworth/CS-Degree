
# Lab Sheet by [Abubakar Ahmed] (Student Id: AA.SC.U3BCA2501097)

You can view the code for the lab sheet on my  [GitHub](https://github.com/Memsworth/CS-Degree/tree/main/Year1-Semester2/Object-Oriented-Programming-using-Java/Week%203/LabSheet1/src).


# Main Class
```Java
public class App {
    public static void main(String[] args) throws Exception {
        var testClass = new Problem1(10, 5);
        testClass.Run();

        var testClass2 = new Problem2();
        testClass2.Message();

        var testClass3 = new Problem3();

        testClass3.ArithmeticProgression(2, 3, 5);

        testClass3.MultiTablePrint(8);

        testClass3.SimpleIntrest(1000, 5, 3);
    }
}
```

# Problem 1: Basic Arithmetic Operations

Write a program (WAP) to declare and initialize two numbers, and then perform the following operations:

1. Add the two numbers.
2. Subtract the two numbers.
3. Multiply the two numbers.
4. Divide the two numbers.
5. Find the remainder of the division of the two numbers using the modulo operator (`%`).

## Solution:

```Java
public class Problem1 {
    private int Num1;
    private int Num2;

    public Problem1(int num1, int num2){
        Num1 = num1;
        Num2 = num2;
    }

    public void Run(){
        Add();
        Sub();
        Multi();
        Divide();
        Reminder();
    }
    
    public void Add(){
        System.out.println(Num1+" + "+Num2+" = "+ (Num1+Num2));
    }
    public void Sub(){
        System.out.println(Num1+" - "+Num2+" = "+ (Num1-Num2));
    }

    public void Multi(){
        System.out.println(Num1+" x "+Num2+" = "+ (Num1*Num2));
    }

    public void Divide(){
        System.out.println(Num1+" / "+Num2+" = "+ (Num1/(double)Num2));
    }

    public void Reminder(){
        System.out.println(Num1+" % "+Num2+" = "+ (Num1%Num2));
    }
}
```

---

# Question 2: Display a Message in Java

**Problem:** Write a program to display the message "Welcome all of you".

To write a simple Java program, follow these basic steps:

1. **Define a Class:**  
	   Every Java program must have at least one class. They act as a blueprint for your objects. Therefore, we must define our class using `class` keyword

2. **Write the Main Method:**  
	   The main method is the entry point of any Java program. It's where the execution starts. Every Java program must have a `main` method, defined as `public static void main(String[] args)`.

3. **Output Statements:**  
	   To display a message or output text to the user, you use the `System.out.println()` method. This method prints the given text to the console, followed by a new line.

```java
public class Problem2 {
    public void Message(){
        System.out.println("Welcome all of you");
    }
}
```

4. **Output Statements:**  
	   Eclipse simplifies the compilation & run process through the run button. However, the traditional way is to use `jvm` to compile using the `javac` keyword. This produces a `.class` file which you can run the program using `java {program name here}` .
---

# Question 3:

1. **WAP to implement Simple Interest.**
2. **WAP to implement Arithmetic Progression.**
3. **WAP to implement Multiplication table of any number of your choice (e.g., 8).**


```java
public class Problem3 {
    public void MultiTablePrint(int val){

        System.out.println("Multiplication table for " + val + ":");
        
        for (int i = 1; i <= 10; i++) {
            System.out.println(val + " x " + i + " = " + (val * i));
        }
    }

    public void ArithmeticProgression(int base, int rate, int term){
        int sum = base;
        for (int i = 0; i < term; i++) {
            System.out.print(sum);
            if (i < term - 1)
                System.out.print(", ");
            sum += rate;
        }
        System.out.println();
    }

    public void SimpleIntrest(int principal, int rate, int time){
        double interest = principal * (rate/100.0) * time;
        System.out.println("The interest on a principal amount of " + principal 
                + " at a rate of " + rate + "% for " + time + " years is: " 
                       + interest);
    }
}
```
