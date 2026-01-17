public class Question3 implements IExercise {

    public void Run() {
        Shape shape = new Shape();
        shape.Print();

        Shape rectangle = new Rectangle();
        rectangle.Print();

        Shape circle = new Circle();
        circle.Print();

        Shape sq = new Square();
        sq.Print();

        Rectangle square = new Square();
        square.Print();
    }

    public class Shape {

        public void Print() {
            System.out.println("This is shape");
        }
    }

    public class Rectangle extends Shape {

        @Override
        public void Print() {
            System.out.println("This is rectangular shape");
        }
    }

    public class Circle extends Shape {

        @Override
        public void Print() {
            System.out.println("This is circular shape");
        }
    }

    public class Square extends Rectangle {
        @Override
        public void Print() {
            System.out.println("Square is a rectangle");
        }
    }
}
