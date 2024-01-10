using System;

public class YJ_sol12
{
	// 모음 제거
	public string solution(string my_string)
	{
		string answer = "";
		string[] arr = my_string.Split('a', 'e', 'i', 'u', 'o');
		for (int i = 0; i < arr.Length; i++)
		{
			answer += arr[i];
		}
		return answer;
	}
}