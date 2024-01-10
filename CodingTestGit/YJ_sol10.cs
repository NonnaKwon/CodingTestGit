using System;

public class YJ_sol10
{
	// 문자열안에 문자열
	public int solution(string str1, string str2)
	{
		int answer = 0;
		if (str1.Contains(str2))
		{
			answer = 1;
		}
		else
		{
			answer = 2;
		}
		return answer;
	}
}