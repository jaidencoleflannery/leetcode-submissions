public class LinkedList {

    private class Node {
        public int val;
        public Node next;

        public Node(int val = 0, Node next = null) {
            this.val = val;
            this.next = next;
        }
    }

    private Node head;
    private Node tail;
    private int count = 0;

    public LinkedList() {
        this.tail = this.head = new Node(-1);
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
        Node node = new Node(val);
        node.next = this.head.next;
        this.head.next = node;
        if(node.next == null) {
            this.tail = node;
        }
        this.count++;
    }

    public void InsertTail(int val) {
        this.tail.next = new Node(val);
        this.tail = this.tail.next;
        this.count++;
    }

    public bool Remove(int index) {
        Node node = this.head;
        int counter = 0;
        while(counter < index && node != null) {
            counter++;
            node = node.next;
        }
        if(node != null && node.next != null) {
            if(node.next == this.tail) {
                this.tail = node;
            }
            node.next = node.next.next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() {
        Node node = this.head.next;
        List<int> vals = new List<int>();
        while(node != null) {
            vals.Add(node.val);
            node = node.next;
        }
        return vals;
    }
}