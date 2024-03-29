﻿using System;

//약수의 개수가 세 개 이상인 수를 합성수라고 합니다.
//자연수 n이 매개변수로 주어질 때 n이하의 합성수의 개수를 return

public class CompositeNumb
{
    public bool HasDivisor(int n)
    {
        int cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                cnt++;
                if (cnt >= 3)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public int solution(int n)
    {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            if (HasDivisor(i))
            {
                answer++;
            }
        }
        return answer;
    }
}
