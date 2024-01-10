using System;

public class YJ_sol05
{
	// 짝수 홀수 개수
	public int[] solution(int[] num_list)
	{
		int[] answer = new int[2];
		int len = num_list.Length;
		for (int i = 0; i < len; i++)
		{
			if (num_list[i] % 2 == 0)
			{
				answer[0]++;
			}
			else
			{
				answer[1]++;
			}
		}
		return answer;


	}
}