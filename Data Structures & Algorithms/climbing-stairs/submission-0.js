class Solution {
    /**
     * @param {number} n
     * @return {number}
     */
    count = 0;
    climbStairs(n) {
        if(n <= 1) {
            return 1;
        }
        let val = this.climbStairs(n - 1) + this.climbStairs(n - 2);
        return val;
    }
}
