using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = Convert.ToInt32(Math.Truncate(Convert.ToSingle(num1) / Convert.ToSingle(num2) * 1000));
return answer;
    }
}