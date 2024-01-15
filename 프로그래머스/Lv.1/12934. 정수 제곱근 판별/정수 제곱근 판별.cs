using System;
public class Solution {
    public long solution(long n) {
        double h = Math.Sqrt(n);
        if (h % 1 != 0) return -1;
        return ((long)h + 1) * ((long)h + 1);
    }
}