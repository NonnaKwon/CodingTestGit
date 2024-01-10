using System;

public class YJ_sol09
{
	// 옷가게 할인 받기
	public int solution(float price)
	{
		int answer = 0;
		if (price >= 500000)
		{
			price = (float)price * 0.8f;
		}
		else if (price >= 300000)
		{
			price = (float)price * 0.9f;
		}
		else if (price >= 100000)
		{
			price = (float)price * 0.95f;
		}
		return (int)price;
	}
}