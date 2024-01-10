using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Sr_3
    {
        public class Solution
        {
            public int[] solution(string myString)
            {
                List<int> answer = new List<int>();
                int i = 0;
                int num = 0;
                foreach (char c in myString)
                {
                    if (c == 'x')
                    {
                        answer.Add(num);
                        num = 0;
                    }
                    else
                    {
                        num++;
                    }
                }
                answer.Add(num);
                return answer.ToArray();
            }
        }
    }
}
