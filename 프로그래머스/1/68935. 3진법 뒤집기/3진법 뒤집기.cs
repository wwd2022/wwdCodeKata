using System;
using System.Text;
using System.Linq;

public class Solution {
    public long solution(int n) {
        StringBuilder sb = new StringBuilder();
        while (n >= 1)
        {
            sb.Append(n % 3);
            n /= 3;
        }
        var s = sb.ToString().ToArray();
        long n2 = 0;
        int j = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int iii = s[i] - '0';
            n2 += j != 0 ? iii * (long)(Math.Pow(3, j)) : iii;
            j++;
        }
        return n2;
    }
}