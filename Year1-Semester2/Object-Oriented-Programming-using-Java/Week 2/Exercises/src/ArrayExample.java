public class ArrayExample implements IExercise {
    public void Run(){
        var arr = new int[] {1, 2, 3, 4, 5};

        for (var element : arr) {
            System.out.println(element);
        }
    }
}
