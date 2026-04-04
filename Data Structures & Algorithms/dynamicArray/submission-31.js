class DynamicArray {
    /**
     * @constructor
     * @param {number} capacity
     */
    constructor(capacity) {
        this.arr = [capacity];
        this.capacity = capacity;
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
        let popped_value = this.arr.pop();
        this.length--;
        return popped_value;
    }

    /**
     * @returns {void}
     */
    resize() {
        this.capacity *= 2;
        const temp_arr = [this.capacity];
        for(let i = 0; i < this.length; i++){
            temp_arr[i] = this.arr[i];
        }
        this.arr = temp_arr;
    }

    /**
     * @returns {number}
     */
    getSize() {
        return this.length;
    }

    /**
     * @returns {number}
     */
    getCapacity() {
        return this.capacity;
    }
}
