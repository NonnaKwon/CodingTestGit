using System;
//배열에서 가장 큰 수를 리턴
public class BiggestNum
{
    public int[] solution(int[] array)
    {
        int[] answer = new int[] { 0, 0 };
        int index = 0;
        int max = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                index = i;
                max = array[i];
            }
        }

        answer[0] = max;
        answer[1] = index;

        return answer;
    }
}
