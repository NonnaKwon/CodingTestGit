﻿using System;

public class YJ_sol20
{
	// 배열의 유사도
	public int solution(string[] s1, string[] s2)
	{
		int answer = 0;
		for (int i = 0; i < s1.Length; i++)
		{
			for (int j = 0; j < s2.Length; j++)
			{
				if (s1[i] == s2[j])
				{
					answer++;
				}
			}
		}
		return answer;
	}
}