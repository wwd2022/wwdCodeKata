using System.Linq;

public class Solution {
    public int[] solution(long n) {
        string nString = new string(n.ToString().ToCharArray().Reverse().ToArray());
        int[] answer = new int[nString.Length];

        for (int i = 0; i < nString.Length; i++)
        {
            answer[i] = int.Parse(nString[i].ToString());
        }

        return answer;
    }
}
