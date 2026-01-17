public class DynamicPolymorphismExample implements IExercise {

    public void Run(){
        Payment item1 = new Payment();
        item1.Pay(100);
        item1 = new UpiPayment();
        item1.Pay(100);
    }

    public class Payment {
        public void Pay(double amount){
            System.out.println("Paid " + amount +" through cash");
        }
    }

    public class UpiPayment extends Payment {
        @Override
        public void Pay(double amount){
            System.out.println("Paid " + amount +" through UPI");
        }
    }
}
