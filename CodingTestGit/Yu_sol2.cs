using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Yu_sol2
    {
        // 분수의 덧셈
        public class Solution
        {
            public int[] solution(int numer1, int denom1, int numer2, int denom2)
            {
                // 분모의 최소 공배수 계산
                int lcm = LCM(denom1, denom2);

                // 각 분수의 곱셈을 통해 통분
                int newNumer1 = numer1 * (lcm / denom1);
                int newNumer2 = numer2 * (lcm / denom2);

                // 분자를 더한 후 기약 분수로 만들기
                int sumNumer = newNumer1 + newNumer2;
                int gcd = GCD(sumNumer, lcm);
                int reducedNumer = sumNumer / gcd;
                int reducedDenom = lcm / gcd;

                // 결과 배열 반환
                return new int[] { reducedNumer, reducedDenom };
            }

            // 최대공약수 계산
            private int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            // 최소공배수 계산
            private int LCM(int a, int b)
            {
                return (a * b) / GCD(a, b);
            }
        }
    }
}
