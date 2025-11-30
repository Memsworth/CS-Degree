public class JumpExampleProblems implements IExercise {
    public void Run(){
        ContinueExample();
    }

    public void BreakExample(){
        var testArray = new int[] {1, 25, 52, 6, 25,100, 52};

        for(var i = 0; i < testArray.length; i++){
            if(testArray[i] > 50 && testArray[i] % 2 == 0){
                System.out.print("At index "+i+" found an even number ");
                System.out.println("bigger than 50: "+testArray[i]);
                break;
            }
        }
    }

    public void ContinueExample(){
        for(var i =0; i<10; i++){
            if(i == 5)
                continue;
            System.out.println(i);
        }
    }
}
