import java.util.Scanner;

public class SelectionExampleProblems implements IExercise {
    public void Run(){
        SwitchExample();
    }

    public void IfBasic(){
        var input = new Scanner(System.in);
        System.out.print("Enter a number: ");
        var num1 = input.nextInt();
        
        input.close();
        
        if(num1 > 0)
            System.out.println("Positive");
        else if(num1 < 0)
            System.out.println("Negative");
        else
            System.out.println("Zero");
    }

    public void NestedIf(){
        var input = new Scanner(System.in);
        System.out.print("Enter a Score: ");
        var num1 = input.nextInt();
        input.close();

        if(num1 >= 90)
            System.out.println("Grade A");
        else if(num1 < 90 && num1 >= 70)
            System.out.println("Grade B");
        else
            System.out.println("Grade C");
    }

    public void SwitchExample(){
        var input = new Scanner(System.in);
        System.out.print("Enter a day number: ");
        var num1 = input.nextInt();
        input.close();

        switch (num1) {
            case 1:
                System.out.println("Monday");
                break;
            case 2:
                System.out.println("Tuesday");
                break;
            case 3:
                System.out.println("Wednesday");
                break;
            case 4:
                System.out.println("Thursday");
                break;
            case 5:
                System.out.println("Friday");
                break;
            case 6:
                System.out.println("Saturday");
                break;
            case 7:
                System.out.println("Sunday");
                break;
            default:
                break;
        }
    }
}


