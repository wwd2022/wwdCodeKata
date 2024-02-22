public class Solution {
    public string solution(string s) {
        int len = s.Length;
        return s.Substring(len / 2 - (1 - len % 2), 2 - len % 2);;
    }
}