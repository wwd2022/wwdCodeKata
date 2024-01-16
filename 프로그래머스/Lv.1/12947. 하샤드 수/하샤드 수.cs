public class Solution {
    public bool solution(int x) {
        string answer = x.ToString();
        int sum = 0;
        for (int i = 0; i < answer.Length; i++)
        {
            sum += int.Parse(answer[i].ToString());
        }
        if (x % sum == 0) return true;
        else return false;
    }
}