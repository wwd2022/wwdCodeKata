public class Solution {
    public int[] solution(long n) {
        char[] chArr = n.ToString().ToCharArray();
        int[] answer = new int[chArr.Length];
        int len = chArr.Length;
        for (int i = 0; i < len; i++) {
            answer[i] = int.Parse(chArr[len - i - 1].ToString());
        }
        return answer;
    }
}