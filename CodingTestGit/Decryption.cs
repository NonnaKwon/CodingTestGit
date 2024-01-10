using System;
using System.Text;
/* 암호 해독
 * 군 전략가 머쓱이는 전쟁 중 적군이 다음과 같은 암호 체계를 사용한다는 것을 알아냈습니다.
        암호화된 문자열 cipher를 주고받습니다.
        그 문자열에서 code의 배수 번째 글자만 진짜 암호입니다.
문자열 cipher와 정수 code가 매개변수로 주어질 때 해독된 암호 문자열을 return
 */

public class Decryption
{
    public string solution(string cipher, int code)
    {
        StringBuilder answer = new StringBuilder();
        int cnt = 0;
        foreach (var c in cipher)
        {
            cnt++;
            if (cnt == code)
            {
                answer.Append(c);
                cnt = 0;
            }
        }
        return answer.ToString();
    }
}
