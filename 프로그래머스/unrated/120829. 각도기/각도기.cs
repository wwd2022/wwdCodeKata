using System;

public class Solution {
    public int solution(int angle) {
        int answer = 0 < angle && angle < 90 ?
            1 : angle == 90 ? 
            2 : 90 < angle && angle < 180 ?
            3 : 4;
        return answer;
    }
}