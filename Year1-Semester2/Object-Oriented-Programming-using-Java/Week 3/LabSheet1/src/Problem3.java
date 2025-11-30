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
