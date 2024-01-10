using System;

public class YJ_sol02
{
	// 특정 문자 제거하기
	public string solution(string my_string, string letter)
	{
		String answer = "";
		string[] temp = my_string.Split(letter);

		for (int i = 0; i < temp.Length; i++)
		{
			answer += temp[i];
		}
		return answer;
	}
}