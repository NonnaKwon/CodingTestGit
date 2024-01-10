using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Yu_sol5
    {
        // 치킨 쿠폰
        public class Solution
        {
            public int solution(int chicken)
            {
                int answer = 0;
                int coupon = chicken;

                do
                {
                    int bonusChicken = coupon / 10;
                    answer += bonusChicken;
                    coupon = bonusChicken + coupon % 10;
                } while (coupon >= 10);

                return answer;
            }
        }
    }
}
