public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        foreach (int i in arr) {
            answer += i;
        }
        return answer / arr.Length;
    }
}