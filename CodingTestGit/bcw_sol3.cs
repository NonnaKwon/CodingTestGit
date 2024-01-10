using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    //배열 자르기
    internal class bcw_sol3
    {
        public int[] solution(int[] numbers, int num1, int num2)
        {
            int length = 0;
            int j = 0;
            if (num1 != 0)
            {
                length = num2 - num1 + 1;
            }
            else
            {
                length = num2 + 1;
            }
            int[] answer = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i >= num1 && num2 >= i)
                {
                    answer[j] = numbers[i];
                    j++;
                }
            }
            return answer;
        }
    }
}
