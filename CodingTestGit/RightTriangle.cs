﻿using System;

public class RightTriangle
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');
        int n = Int32.Parse(s[0]);

        //Console.WriteLine("{0}", n);

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}
