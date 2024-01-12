using System;

public class Solution {
    public int solution(int n) {
        for (int i = 1; i < n >> 1; i++) {
            int f = n % i;
            if (f == 1) return i;
        }
        return n - 1;
    }
}