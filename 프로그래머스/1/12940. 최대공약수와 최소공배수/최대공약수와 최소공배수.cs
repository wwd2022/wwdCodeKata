public class Solution {
    public int[] solution(int n, int m)
    {
        int min = gcd(n, m);
        int max = (n * m) / min;
        int[] answer = new int[] { };
        return new int[] { min, max };
    }

    public int gcd(int n, int m)
    {
        if (m == 0) return n;
        else return gcd(m, n % m);
    }
}