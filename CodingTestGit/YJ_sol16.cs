using System;

public class YJ_sol16
{
	// 세균 증식
	public int solution(int n, int t)
	{
		int answer = 0;
		answer = n * (int)Math.Pow(2, t);
		return answer;
	}
}