public class MinStack {

    private Stack<int> vals;
    int min;

    public MinStack() {
        this.vals = new Stack<int>();
    }
    
    public void Push(int val) {
        if (this.vals.Count == 0) {
            this.min = val;
        } else if (val < min) {
            this.min = val;
        }
        this.vals.Push(val);
    }
    
    public void Pop() {
        if (this.vals.Peek() == this.min) {
            this.vals.Pop();
            if (this.vals.Count != 0) {
                this.min = this.vals.Peek();
                Stack<int> temp = new Stack<int>();
                while (this.vals.Count > 0) {
                    temp.Push(this.vals.Pop());
                    if (temp.Peek() < min) {
                        min = temp.Peek();
                    }
                }
                while (temp.Count > 0) {
                    this.vals.Push(temp.Pop());
                }
            } else {
                this.min = 0;
            }
        } else {
            this.vals.Pop();
        }
    }
    
    public int Top() {
        return this.vals.Peek();
    }
    
    public int GetMin() {
        return this.min;
    }
}
