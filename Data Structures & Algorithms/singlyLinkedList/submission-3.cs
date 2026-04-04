public class Node {
    public int val;
    public Node next;

    public Node(int val) {
        this.val = val;
        this.next = null;
    }

    public Node(int val, Node next) {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    private Node head;
    private Node tail;

    public LinkedList () {
        this.head = new Node(-1);
        this.tail = this.head;
    }

    public int Get(int index) {
        Node cursor = this.head.next;
        int counter = 0;
        while(cursor != null) {
            if(counter == index) {
                return cursor.val;
            } else {
                if(cursor.next != null){
                    cursor = cursor.next;
                    counter++;
                } else {
                    return -1;
                }
            }
        }
        return -1;
    }

    public void InsertHead(int val) {
        Node dummy = new Node(val);
        dummy.next = this.head.next;
        this.head.next = dummy;
        if(dummy.next == null) {
            this.tail = dummy;
        }
    }

    public void InsertTail(int val) {
        this.tail.next = new Node(val);
        this.tail = this.tail.next;
    }

    public bool Remove(int index) {
        int counter = 0;
        Node cursor = this.head;
        Node flag;
        while (counter < index && cursor != null){
            counter++;
            cursor = cursor.next;
        }
        if(cursor != null && cursor.next != null){
            if(cursor.next == this.tail){
                this.tail = cursor;
            }
            cursor.next = cursor.next.next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() {
        List<int> vals = new List<int>();
        Node cursor = this.head.next;
        while (cursor != null) {
            vals.Add(cursor.val);
            cursor = cursor.next;
        }
        return vals;
    }
}