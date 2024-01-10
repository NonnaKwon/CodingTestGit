using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    //숨어있는 숫자의 덧셈(1)
    internal class bcw_sol2
    {
        public int solution(string my_string)
        {
            int sum = 0;

            for(int i = 0; i < my_string.Length; i++)
            {
                if ('0' <= my_string[i] && my_string[i] <= '9')
                   sum+= (int)my_string[i] - (int)'0';
            }
            return sum;
        }
    }
}
