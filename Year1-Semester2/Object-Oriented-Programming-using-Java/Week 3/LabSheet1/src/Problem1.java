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
