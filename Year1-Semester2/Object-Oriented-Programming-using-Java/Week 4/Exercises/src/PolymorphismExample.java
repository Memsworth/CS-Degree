import java.util.ArrayList;
import java.util.EmptyStackException;
import java.util.List;

public class PolymorphismExample implements IExercise {
    public void Run()
    {
        var stack1 = new StackExample<Integer>();

        stack1.Push(10);
        stack1.Push(20);
        System.out.println(stack1.Pop());


        var stringStack = new StackExample<String>();
        stringStack.Push("A");
        stringStack.Push("B");
        System.out.println(stringStack.Pop());
    }

    public interface StackMethods<T> {
        public void Push(T value);
        public T Pop(); 
    }

    public class StackExample<T> implements StackMethods<T> {
        private List<T> Stack = new ArrayList<>();

        @Override
        public void Push(T value){
            Stack.add(value);
        }

        @Override
        public T Pop(){
            if(Stack.isEmpty()) {
                throw new EmptyStackException();
            }
            return Stack.removeLast();
        }
    }
}