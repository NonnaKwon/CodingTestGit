using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Yu_sol4
    {
        // 캐릭터의 좌표
            
        public int[] solution(string[] keyinput, int[] board)
        {
            int[] answer = new int[2] { 0, 0 };
            for (int i = 0; i < keyinput.Length; i++)
            {
                if (keyinput[i] == "left")
                {
                    answer[0]--;
                    if (Math.Abs(answer[0]) > Math.Abs(board[0] / 2))
                        answer[0] = -Math.Abs(board[0] / 2);
                }
                else if (keyinput[i] == "right")
                {
                    answer[0]++;
                    if (Math.Abs(answer[0]) > Math.Abs(board[0] / 2))
                        answer[0] = Math.Abs(board[0] / 2);
                }
                else if (keyinput[i] == "up")
                {
                    answer[1]++;
                    if (Math.Abs(answer[1]) > Math.Abs(board[1] / 2))
                        answer[1] = Math.Abs(board[1] / 2);
                }
                else if (keyinput[i] == "down")
                {
                    answer[1]--;
                    if (Math.Abs(answer[1]) > Math.Abs(board[1] / 2))
                        answer[1] = -Math.Abs(board[1] / 2);
                }
            }

            return answer;
        }
    }
}

