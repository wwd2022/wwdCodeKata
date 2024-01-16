using System;

public class Solution {
    public long solution(long n) {
        char[] answer = n.ToString().ToCharArray();
        System.Array.Sort(answer);
        System.Array.Reverse(answer);
        return long.Parse(answer);
    }
}