public class StaticPolymorphismExample implements IExercise {

    public void Run() {
        var calculator = new Calculator();
        
        System.out.println(calculator.add(1, 2));
        System.out.println(calculator.add(1.0, 5.0));
        System.out.println(calculator.add(1, 2, 3));
    }

    public class Calculator {
        public int add(int a, int b){
            return a+b;
        }

        public double add(double a, double b){
            return a+b;
        }

        public int add(int a, int b, int c){
            return a+b+c;
        }
    }
}
