
# Lab Sheet by [Abubakar Ahmed] (Student Id: AA.SC.U3BCA2501097)

You can view the code for the lab sheet on my  [GitHub](https://github.com/Memsworth/CS-Degree/tree/main/Year1-Semester2/Object-Oriented-Programming-using-Java/Week%205).

## 1. Print all the natural numbers from M to N

```java
public void Problem1(){
    var input = new Scanner(System.in);
    System.out.println("Enter start value: ");
    var m = input.nextInt();
    System.out.println("Enter end value: ");
    var n = input.nextInt();

    input.close();

    if(m > n) {
        System.out.println("M can't be lower than N");
        return;
    }

    var count = 1;
    for(int i = m; i<=n; i++){
        System.out.printf("%-" + 4 + "d", i);
            
        if(count % 4 == 0)
            System.out.println();
        count++;
    }
}
```

---

## 2. Print all the multiples of 4 between 1 and 100

```java
public void Problem2() {
    var count = 1;
    for(var i =4; i< 100; i+=4)
    {
        System.out.printf("%-" + 4 + "d", i);
        if(count % 4 == 0)
            System.out.println();
        count++;        }
}
```

---

## 3. Read a number and check whether it is divisible by any one of the numbers from 1 to 5

```java
public void Problem3() {
    var input = new Scanner(System.in);
    System.out.println("Enter a value: ");
    var m = input.nextInt();
    input.close();

    for(var i = 1; i<6; i++)
    {
        if(m % i == 0)
            System.out.printf("%-" + 4 + "d", i);
    }
}
```

---

## 4. Read a number N and check whether its reverse is greater than N or not

```java
public void Problem4() {
    var input = new Scanner(System.in);
    System.out.println("Enter a value: ");
    var m = input.nextInt();
    input.close();

    var originalNumber = m;
    int temp = Math.abs(m);

    int reverse = 0;

    while (temp != 0) {
        int lastDigit = temp % 10;
        reverse = reverse * 10 + lastDigit;
        temp /= 10;
    }

    if (reverse > Math.abs(originalNumber))
        System.out.println("Reverse of " + originalNumber + " is larger than " + originalNumber);
    else
        System.out.println("Reverse of " + originalNumber + " is smaller than " + originalNumber);
}
```

---

## 5. Read a number and print the multiplication table of that number

```java
public void Problem5() {
    var input = new Scanner(System.in);
    System.out.println("Enter a value: ");
    var m = input.nextInt();
    input.close();

    for(var i=1; i< 11; i++){
        System.out.printf("%d x %2d = %4d%n", m, i, m * i);
    }
}
```

---

## 6. Read a number from the user and check whether it is greater than 100 or not

```java
public void Problem6() {
    var input = new Scanner(System.in);
    System.out.println("Enter a value: ");
    var m = input.nextInt();
    input.close();

    if(m > 100)
        System.out.printf("%d is larger than 100", m);
    else
        System.out.printf("%d is smaller than 100", m);

}
```

---

## 7. Read a year from the user and check whether it is a leap year or not

```java
public void Problem7() {
    var input = new Scanner(System.in);
    System.out.println("Enter a year: ");
    var year = input.nextInt();
    input.close();
    var isLeap = false;

    if(year % 4 == 0)
    {
        if(year % 100 == 0) {
            if(year % 400 == 0){
                isLeap = true;
            }
        }
        else {
            isLeap = true;
        }
    }
    if(isLeap)
        System.out.printf("%d is a leap year", year);
    else
        System.out.printf("%d is not a leap year", year);
}
```

---

## 8. Read a character and check whether it is uppercase or lowercase

```java
public void Problem8() {
    var input = new Scanner(System.in);
    System.out.println("Enter a character: ");
    var userChar = input.next();
    input.close();

    if(userChar.toLowerCase().equals(userChar))
        System.out.printf("%s is lowercase", userChar);
    else
        System.out.printf("%s is lowercase", userChar);
}
```

---

## 9. Electricity Bill Calculation

### Conditions:
- First 50 units: Rs. 0.50/unit
- Next 100 units: Rs. 0.75/unit
- Next 100 units: Rs. 1.20/unit
- Above 250 units: Rs. 1.50/unit

```java
public void Problem9() {
    var input = new Scanner(System.in);
    System.out.println("Enter a units: ");
    var units = input.nextInt();
    input.close();

    var count = 0;
    var sum = 0.0;
    while (count < units) {
        if(count < 50)
            sum+= 0.50;
        else if(count > 50 && count < 100)
            sum+= 0.75;
        else if(count > 100 && count < 250)
            sum+= 1.20;
        else {
            sum+= 2.50;
        }
        count++;
    }
}
```
