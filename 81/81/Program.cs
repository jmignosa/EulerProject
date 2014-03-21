using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace _81
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int x = 0;
            int y = 0;
            int[,] matrix=new int[80,80];

            sw.Start();
            StreamReader sr = new StreamReader(@"matrix.txt");
            while (sr.Peek()>=0)
            {
                y = 0;
                string input =sr.ReadLine();
                string []matrixline= input.Split(',');
                foreach (var square in matrixline)
                {
                    matrix[x,y] = Int32.Parse(square);
                    y++;
                }
                x++;
            }
            //calculate the solution for bottom and right
            for (int i = 78; i >= 0; i--)
            {
                matrix[79, i] += matrix[79, i + 1];
                matrix[i, 79] += matrix[i + 1, 79];
            }

            for (int i = 78; i >= 0; i--)
            {
                for (int j = 78; j >= 0; j--)
                {
                    matrix[i, j] += Math.Min(matrix[i + 1, j], matrix[i, j + 1]);
                }
            }
            sw.Stop();
            Console.WriteLine("the answer {0} took {1} ms", matrix[0, 0],sw.ElapsedMilliseconds);
        }
    }
}
