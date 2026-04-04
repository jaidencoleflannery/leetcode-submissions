class DynamicArray {
    /**
     * @constructor
     * @param {number} capacity
     */
    constructor(capacity) {
        this.capacity = capacity;
        this.arr = [capacity];
        this.length = 0;
    }

    /**
     * @param {number} i
     * @returns {number}
     */
    get(i) {
        return this.arr[i];
    }

    /**
     * @param {number} i
     * @param {number} n
     * @returns {void}
     */
    set(i, n) {
        if(i > this.capacity){
            this.resize();
        }
        if(i > this.length){
            this.length++;
        }
        this.arr[i] = n;
    }

    /**
     * @param {number} n
     * @returns {void}
     */
    pushback(n) {
        if(this.length === this.capacity){
            this.resize();
        }
        this.arr[this.length] = n;
        this.length++;
    }

    /**
     * @returns {number}
     */
    popback() {
        let lastElement = this.arr.pop();
        return lastElement;
    }

    /**
     * @returns {void}
     */
    resize() {
        this.capacity = 2 * this.capacity;
        let newArr = [this.capacity];
        for(let i = 0; i < this.length; i++){
            newArr[i] = this.arr[i];
        }
        this.arr = newArr;
    }

    /**
     * @returns {number}
     */
    getSize() {
        let count = 0;
        for(let i = 0; i < this.length; i++){
            if(this.arr[i] !== undefined){
                count++;
            }
        }
        return count;
    }

    /**
     * @returns {number}
     */
    getCapacity() {
            return this.capacity;
    }
}
