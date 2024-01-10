using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class FindMax
    {
        public class Solution
        {
            public int[] solution(int[] array)
            {
                int[] answer = { 0, -1 };
                for (int i = 0; i < array.Length; i++)
                {
                    int num = array[i];
                    if (answer[0] < num)
                    {
                        answer[0] = num;
                        answer[1] = i;
                    }
                }
                return answer;
            }
        }
    }
}
