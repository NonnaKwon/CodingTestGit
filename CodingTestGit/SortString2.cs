using System;
using System.Linq;
/*영어 대소문자로 이루어진 문자열 my_string이 매개변수로 주어질 때,
 * my_string을 모두 소문자로 바꾸고 알파벳 순서대로 정렬한 문자열을 return 
 */

public class SortString2
{
    public string solution(string my_string)
    {
        string answer = my_string.ToLower();
        answer = String.Concat(answer.OrderBy(ch => ch));
        return answer;
    }
}
