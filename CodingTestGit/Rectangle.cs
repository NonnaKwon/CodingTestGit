using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestGit
{
    internal class Rectangle
    {
        public class Example
        {
            public static void Main()
            {
                String[] s;

                Console.Clear();
                s = Console.ReadLine().Split(' ');

                int n = Int32.Parse(s[0]);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
