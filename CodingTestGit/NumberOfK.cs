using System;

public class NumberOfK
{
	
	
        public int solution(int i, int j, int k)
        {
            int answer = 0;
            string numString = "";
            for (int x = i; x <= j; x++)
            {
                numString = x.ToString();
                for (int y = 0; y < numString.Length; y++)
                {
                    if (numString[y].ToString() == k.ToString())
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }
    
}
