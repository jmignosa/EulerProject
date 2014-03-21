using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace _62
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            
            List<string> digits_8 = new List<string>();
            List<string> digits_8_sort = new List<string>();
            List<string> digits_8_sort2x = new List<string>();
            sw.Start();
            //start with 8 digit integers
            for (BigInteger a = 4640; a < 10000; a++)
            {
                digits_8.Add((a*a*a).ToString());
                char[]temp=(a * a * a).ToString().ToCharArray();
                Array.Sort(temp);
                string temp2 = new string(temp);
                digits_8_sort.Add(temp2);
                digits_8_sort2x.Add(temp2);
            }

            int cubecount = 0;
            int lastcubecount = 0;
            digits_8_sort2x.Sort();

            for(int i=0;i<digits_8_sort2x.Count-1;i++)
            {
         
                if (digits_8_sort2x[i] == digits_8_sort2x[i + 1])
                { lastcubecount = cubecount; cubecount++; }
                else
                { lastcubecount = cubecount; cubecount = 0; }
                
                if (lastcubecount == 4&&cubecount==0)
                {
                    
                    List<int> nums = new List<int>();
                    for (int j = 0; j < digits_8_sort.Count;j++ )
                    {
                        if (digits_8_sort[j] == digits_8_sort2x[i])
                            nums.Add(j); 
                    }
                    
                    if (nums.Count > 6)
                        continue;
                    foreach (var index in nums)
                    {
                        Console.WriteLine(digits_8[index]);
                    }

                    Console.WriteLine("***************Elapsed Time {0} ms ********* CubeCount = {1}", sw.ElapsedMilliseconds, nums.Count);
                    if (nums.Count == 5) return;
                }
                //Console.WriteLine("cube = {0}  sorted = {1}", digits_8[i],digits_8_sort[i]);
            }
            sw.Stop();
            Console.WriteLine("elapsed {0}", sw.Elapsed);
        }
    }
}
