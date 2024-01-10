using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class bcw_sol1
    {   // 자릿수 더하기
        public int solution(int n)
        {
            int sum = 0;
            int b = 0;
            string a = n.ToString();
            foreach (int i in a)
            {

                sum += (i - (int)'0');
            }
            return sum;
        }
    }
}
