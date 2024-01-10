using System;

public class YJ_sol07
{
	// 중앙값 만들기
	public int solution(int[] array)
	{
		Array.Sort(array);
		int num = array.Length / 2;
		return array[num];
	}
}