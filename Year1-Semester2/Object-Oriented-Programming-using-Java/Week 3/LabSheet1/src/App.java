public class App {
    public static void main(String[] args) throws Exception {
        var testClass = new Problem1(10, 5);
        testClass.Run();

        var testClass2 = new Problem2();
        testClass2.Message();

        var testClass3 = new Problem3();

        testClass3.ArithmeticProgression(2, 3, 5);

        testClass3.MultiTablePrint(8);

        testClass3.SimpleIntrest(1000, 5, 3);
    }
}
