public class Question1 implements IExercise {
    public void Run() {
        Parent item1 = new Parent();
        item1.Print();

        Child item2 = new Child();
        item2.Print();

        Parent item3 = new Child();
        item3.Print();
    }

    public class Parent {
        public void Print() {
            System.out.println("This is parent class");
        }
    }

    public class Child extends Parent {

        @Override
        public void Print() {
            System.out.println("This is child class");
        }
    }
}
