using System;
//가위바위보

/* 가위는 2 바위는 0 보는 5로 표현
 * 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때,
 * rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return
 */
public class RSP
{
    public string solution(string rsp)
    {
        string answer = "";
        foreach (char c in rsp)
        {
            if (c == '0')
            {
                answer += "5";
            }
            else if (c == '2')
            {
                answer += "0";
            }
            else if (c == '5')
            {
                answer += "2";
            }
        }

        return answer;
    }
}
