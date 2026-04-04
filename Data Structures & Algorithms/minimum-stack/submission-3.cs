public class MinStack {
    Stack<int> main;
    Stack<int> min;

    public MinStack() {
        main = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
        main.Push(val);
        if (min.Count == 0){
            min.Push(val);
        } else if (val < min.Peek()) {
            min.Push(val);
        } else {
            min.Push(min.Peek());
        }
    }
    
    public void Pop() {
        main.Pop();
        min.Pop();
    }
    
    public int Top() {
        return main.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
