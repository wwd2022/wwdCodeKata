using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] nums = new int[] {0,1,2,3,4,5,6,7,8,9};
        foreach (int n in nums) {
            if (Array.IndexOf(numbers, n) == -1) answer += n;
        }
        return answer;
    }
}