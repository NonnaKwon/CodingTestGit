using System;

public class YJ_sol14
{
	// 중복된 숫자 개수
	public int solution(int[] array, int n)
	{
		int answer = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == n)
			{
				answer++;
			}
		}
		return answer;
	}
}