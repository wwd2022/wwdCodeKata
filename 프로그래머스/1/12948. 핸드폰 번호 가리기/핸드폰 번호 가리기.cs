public class Solution {
    public string solution(string phone_number) {
        int gap = phone_number.Length - 4;
        string answer = phone_number.Substring(gap);
        for (; gap != 0; gap--) {
            answer = "*" + answer;
        }
        return answer;
    }
}