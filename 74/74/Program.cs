using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;

namespace _74
{
    class Program
    {
        public static long factorial(long fact)
        {
            if (fact == 0)
                return 1;
            if (fact > 1)
                return fact*factorial(fact - 1);
            return fact;
        }
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            checked
            {
                bool keepgoing = true;
                int count = 0;
                int maxcount = 0;
                int sixtycount=0;
                for (long i = 11; i < 1000000; i++)
                {
                    //while indexof==-1 keep iterating here
                    string numero = i.ToString();
                    long sum = 0;
                    keepgoing = true;
                    HashSet<long> temp = new HashSet<long>();
                    while (keepgoing)
                    {
                        if (sum!=0)
                            numero = sum.ToString();
                        sum = 0;
                        for (int j = 0; j < numero.Length; j++)
                        {
                            long number = Int64.Parse(numero.Substring(j, 1));
                            sum += factorial(number);
                        }
                        if (temp.Contains(sum)) 
                        { 
                            keepgoing = false;
                            //Console.WriteLine("{0} has {1} terms {2}", i, temp.Count,maxcount);
                            count = temp.Count;
                            if (count > maxcount)
                                maxcount = count;
                            if (temp.Count == 59)
                                sixtycount++;
                        }
                        else
                            temp.Add(sum);
                    }
                }
                sw.Stop();
                Console.WriteLine("There are {0} numbers which produce 60 length nonrepeating. This took {1} ms", sixtycount,sw.ElapsedMilliseconds);
            }
        }
    }
}
