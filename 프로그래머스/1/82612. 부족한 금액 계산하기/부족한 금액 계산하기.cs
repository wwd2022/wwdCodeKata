using System;

class Solution
{
    public long solution(int price, long money, int count)
    {
        long a = 0;
        long b = price;
        for (int i = 0; i < count; i++) 
        {
            money -= b;
            b += price;
        }
        if (money > 0) money = 0;
        return -(money);
    }
}