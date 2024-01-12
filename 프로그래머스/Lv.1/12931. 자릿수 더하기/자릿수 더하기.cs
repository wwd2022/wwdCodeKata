using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        char[] chArr = n.ToString().ToCharArray();
        foreach (char ch in chArr) {
            answer += int.Parse(ch.ToString());
        }
        return answer;
    }
}