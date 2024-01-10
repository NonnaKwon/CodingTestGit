using System;

public class YJ_sol03
{
	// 머쓱이보다 키 큰 사람
	public int solution(int[] array, int height)
	{
		int answer = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] > height)
			{
				answer++;
			}
		}
		return answer;
	}
}