public class Question2 implements IExercise {
    
    public void Run(){
        var sq1 = new Square(-1.0);
        System.out.println("Size: "+ sq1.GetSize());
        System.out.println("Area: "+ sq1.GetArea());
        System.out.println("Paramter Method: "+ sq1.GetParamter());
        System.out.println("ToStringMethod: "+ sq1.ToString());




        var sq2 = new Square(2.0, "Blue");
        System.out.println("Color: "+ sq2.GetColor());
        System.out.println("Size: "+ sq2.GetSize());
        System.out.println("Area: "+ sq2.GetArea());
        System.out.println("Paramter Method: "+ sq2.GetParamter());
        System.out.println("ToStringMethod: "+ sq2.ToString());

    }

    public class Square {
        private double Size;
        private String Color;

        public Square(){
            Size = 0;
            Color = "White";
        }

        public Square(double size){
            Size = size;
            Color = "White";
        }

        public Square(double size, String color){
            Size = size;
            Color = color;
        }

        public double GetSize(){
            return Size;
        }

        public String GetColor(){
            return Color;
        }

        public double GetArea(){
            return Math.pow(Size, 2);
        }

        public double GetParamter(){
            return 4 * Size;
        }

        public String ToString() {
            return "Square[size = "  + Size + "]" ;
        }

        public void SetColor(String color){
            Color = color;
        }

        public void SetSize(double size){
            Size = size;
        }

        public void SetColorAndSize(double size, String color){
            Size = size;
            Color = color;
        }
    }
}