public class ClassExampleProblems implements IExercise{
    public void Run(){
        var testClass1 = new Book("Ahh", "Baaa");
        var testClass2 = new Book();

        testClass1.Message();
        testClass2.Message();
    }

    public class Rectangle {
        
        private double Width;
        private double Height;
        
        public Rectangle(double height, double width){
            Height = height;
            Width = width;
        }

        public double GetArea(){
            return Height * Width;
        }

        public void Message(){
            System.out.println("The area of the rectangle is: "+GetArea());
        }
    }

    public class Book {
        private String Title;
        private String Author;

        public Book(String title, String author){
            Title = title;
            Author = author;
        }
        public Book(){
            Title = "Untitled";
            Author = "Unknown";
        }

        public void Message(){
            System.out.println("Title: "+Title+" Author: "+ Author);
        }
    }
    
}
