import java.util.Scanner;

public class Two25 implements IExercise{
    
    public void Run(){

        final int THREE = 3;
        var input = new Scanner(System.in);

        System.out.print("Enter a number: ");
        int num1 = input.nextInt();

        input.close();

        if(num1 % THREE != 0){
            System.out.println(num1+ "is not divisible by "+ THREE);
            return;
        }

        System.out.println(num1+" is divisible by "+THREE+ " & the anwer is "+(num1/THREE));
    }
}
