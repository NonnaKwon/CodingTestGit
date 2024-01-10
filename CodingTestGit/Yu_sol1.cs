using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Yu_sol1
    {
        // 문제 이름 : 주사위의 개수
        public class Solution
        {
            public int solution(int[] box, int n)
            {
                int answer = 0;
                int a = box[0] / n;
                int b = box[1] / n;
                int c = box[2] / n;
                answer = a * b * c;
                return answer;
            }
        }
    }
}
