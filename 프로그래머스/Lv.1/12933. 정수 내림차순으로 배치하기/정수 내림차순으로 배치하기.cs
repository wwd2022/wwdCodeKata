using System;

public class Solution {
    public long solution(long n) {
        char[] answer = n.ToString().ToCharArray();
        Array.Sort(answer);
        Array.Reverse(answer);
        return long.Parse(answer);
    }
}