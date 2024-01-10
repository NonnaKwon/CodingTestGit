using System;

//약수 구하기
//정수 n이 매개변수로 주어질 때, n의 약수를 오름차순으로 담은 배열을 return
public class DivisorFinder
{
    public int[] solution(int n)
    {

        int cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                cnt++;
            }
        }
        //배열크기 동적할당하기 커찮아서 두번돌림 zzzzzzzzzzz
        int[] answer = new int[cnt];
        cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                answer[cnt] = i;
                cnt++;
            }
        }

        return answer;
    }
}
