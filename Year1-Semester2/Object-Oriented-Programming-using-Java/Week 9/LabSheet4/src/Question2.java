public class Question2 implements IExercise {

    public void Run() {

        Rectangle r1 = new Rectangle(5, 10);
        System.out.println("Rectangle 1:");
        System.out.println("Length: " + r1.GetLength());
        System.out.println("Area: " + r1.GetArea());
        System.out.println("Perimeter: " + r1.GetPerimeter());
        System.out.println();

        Square s1 = new Square(4);
        System.out.println("Square 1:");
        System.out.println("Length: " + s1.GetLength());
        System.out.println("Area: " + s1.GetArea());
        System.out.println("Perimeter: " + s1.GetPerimeter());
        System.out.println();
    }

    public class Rectangle {

        private int Length;
        private int Breadth;

        public Rectangle(int length, int breadth) {
            Length = length;
            Breadth = breadth;
        }

        public int GetArea() {
            return Length * Breadth;
        }

        public int GetPerimeter() {
            return 2 * (Length + Breadth);
        }

        public int GetLength() {
            return Length;
        }
    }

    public class Square extends Rectangle {
        public Square(int length) {
            super(length, length);
        }

        @Override
        public int GetArea() {
            return (int) Math.pow((double) GetLength(), 2);
        }

        @Override
        public int GetPerimeter() {
            return 4 * GetLength();
        }
    }
}
