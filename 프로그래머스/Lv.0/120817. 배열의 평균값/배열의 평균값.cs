using System;

public class Solution {
    public double solution(int[] numbers) {
        double sumNum = 0;
        for (int i = 0; i < numbers.Length; i++) {
            sumNum += numbers[i];
        };
        return sumNum / numbers.Length;
    }
}