using System;
using System.Linq;

public class YJ_sol11
{
	// 삼각형의 완성조건 (1)
	public int solution(int[] sides)
	{
		int answer = 0;
		int max = sides.Max();
		int total = sides.Sum();

		if (total - max > max)
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