using System;
using System.Linq;

public class YJ_sol15
{
	// 문자 반복 출력하기
	public string solution(string my_string, int n)
	{
		string answer = "";
		char[] charArr = my_string.ToArray();
		for (int i = 0; i < charArr.Length; i++)
		{
			for (int j = 0; j < n; j++)
			{
				answer = answer + my_string[i];
			}
		}
		return answer;
	}
}