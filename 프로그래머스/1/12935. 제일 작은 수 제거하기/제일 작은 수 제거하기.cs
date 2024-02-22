using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length == 1) return new int[1] {-1};
        List<int> answer = arr.ToList();
        answer.Remove(answer.Min());
        return answer.ToArray();
    }
}