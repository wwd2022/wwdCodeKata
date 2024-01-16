public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        int i = a < b ? a : b;
        int max = a < b ? b : a;
        for (; i <= max; i++) {
            answer += i;
        }
        return answer;
    }
}