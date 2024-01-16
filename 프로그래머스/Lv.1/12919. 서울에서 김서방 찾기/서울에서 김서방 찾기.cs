public class Solution {
    public string solution(string[] seoul) {
        return $"김서방은 {System.Array.FindIndex(seoul, e => e == "Kim")}에 있다";
    }
}