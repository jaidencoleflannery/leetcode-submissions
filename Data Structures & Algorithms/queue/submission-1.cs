class Node {
    public int val;
    public Node next;
    public Node prev;
    public Node(){}
    public Node(int value){
        this.val = value;
    }
}

class Deque {

    Node head;
    Node tail;
    int length = 0;

    public Deque() {
        this.head = new Node();
        this.tail = this.head;
    }

    public bool isEmpty() {
        if(this.length == 0) {
            return true;
        } else {
            return false;
        }
    }

    public void append(int value) {
        if(this.length == 0) {
            this.head = new Node(value);
            this.tail = this.head;
        } else {
            this.tail.next = new Node(value);
            this.tail.next.prev = this.tail;
            this.tail = this.tail.next;
        }
        this.length++;
    }

    public void appendleft(int value) {
        if(length > 0) {
            this.head.prev = new Node(value);
            this.head.prev.next = this.head;
            this.head = this.head.prev;
            this.length++;
        } else {
            this.head = new Node(value);
            this.tail = this.head;
            this.length++;
        }
    }

    public int pop() {
        if(this.length > 1){
            var value = this.tail.val;
            this.tail = this.tail.prev;
            this.length--;
            return value;
        } else if (this.length > 0){
            var value = this.head.val;
            this.head = null;
            this.length--;
            return value;
        } else {
            return -1;
        }
    }

    public int popleft() {
        if(this.length > 0){
            var value = this.head.val;
            this.head = this.head.next;
            this.length--;
            return value;
        } else {
            return -1;
        }        
    }
}
