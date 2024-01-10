using System;
using System.Collections.Generic;
/*정수 n과 정수 배열 numlist가 매개변수로 주어질 때, 
 * numlist에서 n의 배수가 아닌 수들을 제거한 배열을 return
 */

public class MultipleN
{
    public int[] solution(int n, int[] numlist)
    {
        List<int> answer = new List<int>();
        List<int> list = new List<int>(numlist);
        foreach (var num in list)
        {
            if (num % n == 0)
            {
                answer.Add(num);
            }
        }
        return answer.ToArray();
    }
}
