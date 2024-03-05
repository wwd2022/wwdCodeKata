public class Solution {
    public bool solution(string s) {
        char[] chars = s.ToCharArray();
        if (chars.Length != 4 && chars.Length != 6) return false;
        for (int i = 0; chars.Length > i; i++) {
            char c = chars[i];
            if (!('0' <= c && c <= '9'))
                return false;
        }
        return true;
    }
}