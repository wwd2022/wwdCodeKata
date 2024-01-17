using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answer = new List<int>();
        foreach (int e in arr) {
            if (e % divisor == 0) answer.Add(e);
        }
        if (answer.Count == 0) answer.Add(-1);
        answer.Sort();
        return answer.ToArray();
    }
}