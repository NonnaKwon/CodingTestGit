using System;


public class YJ_sol17
{
	// 최댓값 만들기 (1)
	public int solution(int[] numbers)
	{
		int len = numbers.Length;
		int maxFir = numbers.Max();
		int maxFirIndex = 0;
		int maxSec = 0;
		for (int i = 0; i < len; i++)
		{
			if (maxFir == numbers[i])
			{
				maxFirIndex = i;
			}
		}
		for (int i = 0; i < len; i++)
		{
			if (maxFirIndex != i && maxFir >= numbers[i] && maxSec < numbers[i])
			{
				maxSec = numbers[i];
			}
		}
		return maxFir * maxSec;
	}
}