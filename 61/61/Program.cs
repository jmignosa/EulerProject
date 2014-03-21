using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _61
{
    class Program
    {
        static List<string[]>[] shapes = new List<string[]>[6]; //stored in array in order by number of sides
        public static int tri(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public static int sq(int n)
        {
            return (n * n );
        }
        public static int penta(int n)
        {
            return (n * (3 * n - 1)) / 2;
        }
        public static int hexa(int n)
        {
            return n*(2*n-1);
        }
        public static int hepta(int n)
        {
            return (n*(5*n-3))/2;
        }
        public static int octa(int n)
        {
            return n * (3 * n - 2);
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Func<int,int>[] shapefunc = {tri,sq,penta,hexa,hepta,octa };

            for (int i = 0; i < 6; i++)
                shapes[i] = new List<string[]>();
            
            for (int i = 0; i < 6; i++)
            {
                int n = 18;
                while (shapefunc[i](n) < 9999)
                {
                    n++;
                    int temp = shapefunc[i](n);
                    if (temp < 1000)
                        continue;
                    if (temp > 9999)
                        continue;
                    string[] ab= new string[2];
                    ab[0]=temp.ToString().Substring(0, 2);
                    ab[1]=temp.ToString().Substring(2, 2);
                    shapes[i].Add(ab);
                }
            }

            Console.WriteLine("elapsed time filling shapes {0} ", sw.ElapsedMilliseconds);
            ///////////////////////////remove non possibilities. any first two that don't exist as second two.
            int testcount = 0;
            List<string[]> arr2remove = new List<string[]>();
            for (int b = 0; b < 6; b++)
            {
                arr2remove.Clear();
                foreach (string[] num in shapes[b])
                {
                    testcount = 0;
                    for (int c = 0; c < 6; c++)
                    {
                        if (c == b) continue;
                        foreach (string[] arr in shapes[c])
                        {
                            if (num[0] == arr[1])
                                testcount++;
                        }
                    }
                    if (testcount == 0)
                        arr2remove.Add(num);

                }
                foreach (string[] temp in arr2remove)
                    shapes[b].Remove(temp);
            }
            ///////////////////////////remove non possibilities. any second two that don't exist as first two.
            for (int b = 0; b < 6; b++)
            {
                arr2remove.Clear();
                foreach (string[] num in shapes[b])
                {
                    testcount = 0;
                    for (int c = 0; c < 6; c++)
                    {
                        if (c == b) continue;
                        //Predicate<string[]> matchfinder = (string[] str) => { return num[0] == shapes.; };
                        foreach (string[] arr in shapes[c])
                        {
                            if (num[1] == arr[0])
                                testcount++;
                        }
                    }
                    if (testcount == 0)
                        arr2remove.Add(num);

                }
                foreach (string[] temp in arr2remove)
                    shapes[b].Remove(temp);
            }
            Console.WriteLine("Checkpoint 1 {0} ms",sw.ElapsedMilliseconds);

            for (int x=0;x<shapes[0].Count;x++)
                for (int y=0;y<shapes[1].Count;y++)
                    for (int z=0;z<shapes[2].Count;z++)
                        for (int u=0;u<shapes[3].Count;u++)
                            for (int v=0;v<shapes[4].Count;v++)
                                for (int w = 0; w < shapes[5].Count; w++)
                                {
                                    string a, b, c, d, e, f, g, h, i, j, k, l;
                                    
                                    a = shapes[0][x][0];
                                    b = shapes[0][x][1];
                                    c = shapes[1][y][0];
                                    d = shapes[1][y][1];
                                    e = shapes[2][z][0];
                                    f = shapes[2][z][1];
                                    g = shapes[3][u][0];
                                    h = shapes[3][u][1];
                                    i = shapes[4][v][0];
                                    j = shapes[4][v][1];
                                    k = shapes[5][w][0];
                                    l = shapes[5][w][1];
                                    //if (k == "12") Console.WriteLine("{0} {1}",k, l);
                                    if (a == b || c == d || e == f || g == h || i == j || k == l) continue;
                                    if (a == c||a==e||a==g||a==i||a==k)
                                        continue;
                                    if (c == e || c == g  || c == i || c == k)
                                        continue;
                                    if (e == g || e == i || e == k)
                                        continue;
                                    if ( g == i || g == k)
                                        continue;
                                    if (i == k)
                                        continue;
                                    if (b==d||b==f||b==h||b==j||b==l)
                                        continue;
                                    if (d == f || d == h || d == j || d == l)
                                        continue;
                                    if (f == h || f == j || f == l)
                                        continue;
                                    if (h == j || h == l)
                                        continue;
                                    if (j == l)
                                        continue;
                                   // Console.WriteLine("{0}{1}   {2}{3}  {4}{5}  {6}{7}  {8}{9}  {10}{11}", a, b, c, d, e, f, g, h, i, j, k, l);
                                    
                                    if (!(a == d || a == f || a == h || a == j || a == l))
                                        continue;
                                    if (!(c == b || c == f || c == h || c == j || c == l))
                                        continue;
                                    if (!(e == b || e == d || e == h || e == j || e == l))
                                        continue;
                                    if (!(g == b || g == d || g == f || g == j || g == l))
                                        continue;
                                    if (!(i == b || i == d || i == h || i == f || i == l))
                                        continue;
                                    if (!(k == b || k == d || k == f || k == h || k == j))
                                        continue;
                                    //Console.WriteLine("{0}{1}   {2}{3}  {4}{5}  {6}{7}  {8}{9}  {10}{11}", a, b, c, d, e, f, g, h, i, j, k, l);
                                    
                                    if (!(b == c || b == e || b == g || b == i || b == k))
                                        continue;
                                    if (!(d == a || d == e || d == g || d == i || d == k))
                                        continue;
                                    if (!(f == a || f == c || f == g || f == i || f == k))
                                        continue;
                                    if (!(h == a || h == c || h == e || h == i || h == k))
                                        continue;
                                    if (!(j == a || j == c || j == e || j == g || j == k))
                                        continue;
                                    if (!(l == a || l == c || l == e || l == g || l == i))
                                        continue;
                                    
                                    Console.WriteLine("{0}{1}   {2}{3}  {4}{5}  {6}{7}  {8}{9}  {10}{11}", a, b, c, d, e, f, g, h, i, j, k, l);    
                                    
                                }
            sw.Stop();
            Console.WriteLine("Elapsed time {0}", sw.ElapsedMilliseconds);
        }
    }
}
