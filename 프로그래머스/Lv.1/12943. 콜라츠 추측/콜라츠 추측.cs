public class Solution {
    public int solution(long num) {
        if (num == 1) return 0;
        for (int i = 1; i <= 500; i++)
        {
            num = (num & 1) == 1 ? num * 3 + 1 : num / 2;
            if (num == 1) return i;
        }
        return -1;
    }
}