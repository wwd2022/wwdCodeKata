using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for (int i = left; i <= right; i++)
        {
            int count = 1;
            for (int j = 1; j <= i >> 1; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            answer += (count & 1) == 0 ? i : -i;
        }
        return answer;
    }
}