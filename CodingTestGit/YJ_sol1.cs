using System;

public class YJ_sol1
{
	// 아이스 아메리카노
	public int[] solution(int money)
	{
		int[] answer = new int[2];
		int cup = 0;
		while (money >= 5500)
		{
			money -= 5500;
			cup++;
		}
		answer[0] = cup;
		answer[1] = money;
		return answer;
	}
}