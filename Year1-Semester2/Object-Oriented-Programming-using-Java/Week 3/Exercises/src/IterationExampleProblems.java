import java.util.Scanner;

public class IterationExampleProblems implements IExercise {
    public void Run(){
        ForEachExample();
    }

    public void WhileExample(){
        var i = 0;
        while (i<10) {
            System.out.println(i);
            i++;
        }
    }
    public void DoWhileExample(){

        var input = new Scanner(System.in);
        int num1;
        do 
        {
            System.out.print("Enter a number: ");
            num1 = input.nextInt();
        }while (num1 < 1);

        input.close();
        System.out.println("Entered a valid number: "+num1);
    }

    public void ForExample(){
        System.out.println("Printing sum from 1 to 100");
        var sumVal=0;
        for(var i =1; i<101; i++){
            sumVal+=i;
        }
        System.out.println("total = "+sumVal);
    }

    public void ForEachExample(){
        var testAray = new String[] {"Hello", "World", "Java"};
        
        for (String string : testAray) {
            System.out.println(string.toUpperCase());
        }
    }
}
