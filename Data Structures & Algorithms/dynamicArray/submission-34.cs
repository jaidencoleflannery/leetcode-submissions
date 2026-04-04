public class DynamicArray {
    private int capacity;
    private int length;
    private int[] arr;
    
    public DynamicArray(int capacity) {
        this.capacity = capacity;
        this.length = 0;
        this.arr = new int[this.capacity];
    }

    public int Get(int i) {
        return this.arr[i];
    }

    public void Set(int i, int n) {
        this.arr[i] = n;
    }

    public void PushBack(int n) {
        if(this.length == this.capacity){
            Resize();
        }
        this.arr[this.length] = n;
        length++;
    }

    public int PopBack() {
        if(length > 0){
            length--;
        }
        return this.arr[this.length];
    }

    private void Resize() {
        this.capacity = this.capacity * 2;

        int[] tempArr = new int[this.capacity];
        for(int i = 0; i < this.length; i++){
            tempArr[i] = this.arr[i];
        }
        this.arr = tempArr;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}
