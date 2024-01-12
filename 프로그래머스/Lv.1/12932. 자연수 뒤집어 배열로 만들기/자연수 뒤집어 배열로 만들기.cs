public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] {};

        char[] charArray = n.ToString().ToCharArray();
        System.Array.Reverse(charArray);

        answer = System.Array.ConvertAll(charArray, c => (int)char.GetNumericValue(c));

        return answer;
    }
}