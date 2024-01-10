using System;

public class Solution
{
    public double solution(int[] numbers)
    {
        double Sum = 0;
        foreach (double i in numbers)
        {
            Sum += i;
        }

        double a = Sum / numbers.Length;
        return a;
    }
}