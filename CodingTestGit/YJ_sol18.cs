﻿using System;

public class YJ_sol18
{
	// 제곱수 판별하기
	public int solution(int n)
	{
		int answer = 0;
		for (int i = 1; i < 1000000; i++)
		{
			if (i * i == n)
			{
				answer = 1;
				break;
			}
			else
			{
				answer = 2;
			}
		}
		return answer;
	}
}