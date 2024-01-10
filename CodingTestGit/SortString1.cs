using System;
/*
 * 문자열 my_string이 매개변수로 주어질 때, 
 * my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 return
 */
public class SortString1
{
    public int[] solution(string my_string)
    {

        int cnt = 0;
        int result;
        foreach (char c in my_string)
        {
            if (int.TryParse(c.ToString(), out result))
            {

                cnt++;
            }
        }
        int[] answer = new int[cnt];
        cnt = 0;
        foreach (char c in my_string)
        {
            if (int.TryParse(c.ToString(), out result))
            {
                answer[cnt] = result;
                cnt++;
            }
        }
        Array.Sort(answer);

        return answer;
    }
}
