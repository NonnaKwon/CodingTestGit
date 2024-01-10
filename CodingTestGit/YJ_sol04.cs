using System;

public class YJ_sol04
{
	// 배열 두 배 만들기
	public int[] solution(int[] numbers)
	{
		int[] answer = new int[] { };
		int len = numbers.Length;
		for (int i = 0; i < len; i++)
		{
			numbers[i] = numbers[i] * 2;
		}
		return numbers;
	}
}