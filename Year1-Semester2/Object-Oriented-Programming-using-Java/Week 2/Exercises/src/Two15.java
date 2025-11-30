import java.util.Scanner;

public class Two15 implements IExercise {

    public void Run(){
        var input = new Scanner(System.in);
        
        System.out.print("Enter a number: ");
        var num1 = input.nextInt();

        System.out.print("Enter a number: ");
        var num2 = input.nextInt();

        input.close();

        if(num1 > (Integer.MAX_VALUE/2) 
            || num2 > (Integer.MAX_VALUE/2))
        {
            System.out.println("Value too high");
            return;
        }

        var squareNum1 = Math.pow(num1, 2);
        var squareNum2 = Math.pow(num2, 2);

        System.out.println("num1: "+num1);
        System.out.println("num2: "+num2);
        System.out.println("sqaure num1: "+squareNum1);
        System.out.println("sqaure num2: "+squareNum2);
        System.out.println("sum of squares: "
            +(squareNum1+squareNum2));
    }
}
