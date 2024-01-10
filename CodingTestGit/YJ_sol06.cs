using System;
using System.Linq;

public class YJ_sol06
{
	// 문자열 뒤집기
	public string solution(string my_string)
	{
		char[] str = my_string.ToArray();
		Array.Reverse(str);
		string answer = new String(str);

		return answer;
	}
}